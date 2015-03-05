/*
 * Author: Viacheslav Soroka
 * 
 * This file is part of IGE <https://github.com/destrofer/IGE>.
 * 
 * IGE is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * IGE is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License
 * along with IGE.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;

using IGE;
using IGE.Platform;

namespace IGE.Input {
	/// <summary>
	/// </summary>
	public static class IL {
		public static readonly Version ExpectedDriverVersion = new Version(9, 0, 0);
		
		/// <summary>
		/// We are leaving this public for those crazy people, who no matter
		/// what want to have low level access to native functions.
		/// </summary>
		public static IInputDriver Driver = null;
		
		static IL() {
			Driver = DriverManager.LoadDriver<IInputDriver>(GameConfig.InputDriver, ExpectedDriverVersion);
			Driver.Initialize();
		}
		
		public static IInputDevice[] InputDevices { get { return Driver.InputDevices; } }
		public static IMouseDevice[] MouseDevices { get { return Driver.MouseDevices; } }
		public static IKeyboardDevice[] KeyboardDevices { get { return Driver.KeyboardDevices; } }
		public static IControllerDevice[] ControllerDevices { get { return Driver.ControllerDevices; } }
		public static IPenDevice[] PenDevices { get { return Driver.PenDevices; } }
		public static ITouchDevice[] TouchDevices { get { return Driver.TouchDevices; } }
		
		public static IMouseDevice FirstMouseDevice { get { return Driver.MouseDevices[0]; } }
		public static IKeyboardDevice FirstKeyboardDevice { get { return Driver.KeyboardDevices[0]; } }
		public static IControllerDevice FirstControllerDevice { get { return Driver.ControllerDevices[0]; } }
		public static IPenDevice FirstPenDevice { get { return Driver.PenDevices[0]; } }
		public static ITouchDevice FirstTouchDevice { get { return Driver.TouchDevices[0]; } }

		public static void RescanDevices() {
			Driver.RescanDevices();
		}
		
	}
}
