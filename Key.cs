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
	/// <summary>
	/// The available keyboard keys.
	/// </summary>
	public enum Key : int
	{
		LButton = 0x01, LeftButton = LButton,
		RButton, RightButton = RButton,
		Cancel,
		MButton, MiddleButton = MButton,
		
		Backspace = 0x08,
		Tab,
		
		Clear = 0x0C,
		Enter, Return = Enter,
		
		Shift = 0x10,
		Control,
		Alt, Menu = Alt,
		Pause,
		Capital,

		Kana = 0x15, Hangeul = Kana, Hangul = Kana,
		Junja = 0x17,
		Final,
		Hanja, Kanji = Hanja,
		
		Escape = 0x1B,
		
		Convert = 0x1C,
		NonConvert = 0x1D,
		Accept = 0x1E,
		ModeChange = 0x1F,
		
		Space = 0x20,
		PageUp, Prior = PageUp,
		PageDown, Next = PageDown,
		End,
		Home,
		Left,
		Up,
		Right,
		Down,
		Select,
		Print,
		Execute,
		PrintScreen, Snapshot = PrintScreen,
		Insert,
		Delete,
		Help,

		Number0 = 0x30,
		Number1,
		Number2,
		Number3,
		Number4,
		Number5,
		Number6,
		Number7,
		Number8,
		Number9,
		
		A = 0x41,
		B,
		C,
		D,
		E,
		F,
		G,
		H,
		I,
		J,
		K,
		L,
		M,
		N,
		O,
		P,
		Q,
		R,
		S,
		T,
		U,
		V,
		W,
		X,
		Y,
		Z,

		LWin = 0x5B, LeftWin = LWin,
		RWin, RightWin = RWin,
		Apps, Application = Apps,

		Numpad0 = 0x60,
		Numpad1,
		Numpad2,
		Numpad3,
		Numpad4,
		Numpad5,
		Numpad6,
		Numpad7,
		Numpad8,
		Numpad9,
		
		Multiply,
		Add,
		Separator,
		Subtract,
		Dot, Decimal = Dot,
		Divide,
		
		F1 = 0x70,
		F2,
		F3,
		F4,
		F5,
		F6,
		F7,
		F8,
		F9,
		F10,
		F11,
		F12,
		F13,
		F14,
		F15,
		F16,
		F17,
		F18,
		F19,
		F20,
		F21,
		F22,
		F23,
		F24,

		NumLock = 0x90,
		ScrollLock = 0x91,

		LShift = 0xA0, LeftShift = LShift,
		RShift, RightShift = RShift,
		LControl, LeftControl = LControl,
		RControl, RightControl = RControl,
		LAlt, LeftAlt = LAlt,
		RAlt, RightAlt = RAlt,

		ProcessKey = 0xE5,

		ATTN = 0xF6,
		CRSEL,
		EXSEL,
		EREOF,
		PLAY,
		ZOOM,
		NONAME,
		PA1,
		OemClear
	}
	
	public struct KeyAndChar {
		public Key Key;
		public char Char;
		public static KeyAndChar Zero = new KeyAndChar { Key = (Key)0, Char = (char)0 };
	}
}