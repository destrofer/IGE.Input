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

namespace IGE.Input {
	public delegate void KeyEventHandler(KeyEventArgs args);
	
	public class KeyEventArgs : EventArgs {
		public IKeyboardDevice Keyboard;
		public Key Key;
		public char Char;
		
		public KeyEventArgs(IKeyboardDevice keyboard, Key key, char chr) {
			Keyboard = keyboard;
			Key = key;
			Char = chr;
		}
		
		public KeyEventArgs(IKeyboardDevice keyboard, Key key) : this(keyboard, key, char.MinValue) {
		}
	}
}
