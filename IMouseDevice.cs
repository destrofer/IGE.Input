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

using IGE.Platform;

namespace IGE.Input {
	/// <summary>
	/// </summary>
	public interface IMouseDevice : IInputDevice {
		bool Visible { get; set; }
		bool Clipped { get; set; }
		bool InfinityMode { get; set; }
		
		INativeWindow Window { get; set; }
		
		int X { get; }
		int Y { get; }
		int Wheel { get; }
		MouseButton Buttons { get; }

		int PrevX { get; }
		int PrevY { get; }
		int PrevWheel { get; }
		MouseButton PrevButtons { get; }

		int DeltaX { get; }
		int DeltaY { get; }
		int DeltaWheel { get; }
		MouseButton ChangedButtons { get; }

		bool LeftButtonDown { get; }
		bool RightButtonDown { get; }
		bool MiddleButtonDown { get; }

		bool LeftButtonUp { get; }
		bool RightButtonUp { get; }
		bool MiddleButtonUp { get; }
		
		bool LeftButtonWasDown { get; }
		bool RightButtonWasDown { get; }
		bool MiddleButtonWasDown { get; }

		bool LeftButtonWasUp { get; }
		bool RightButtonWasUp { get; }
		bool MiddleButtonWasUp { get; }
		
		Point2 NativePosition { get; }
	}
}
