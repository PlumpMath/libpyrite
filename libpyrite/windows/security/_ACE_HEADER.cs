using System;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.security {


    /// <summary>
    /// ACE �̃w�b�_�ł��B
    /// </summary>
    public struct _ACE_HEADER {
        /// <summary>
        /// 
        /// </summary>
        public static readonly uint SizeOf = (uint)Marshal.SizeOf( typeof( _ACE_HEADER ) );


        /// <summary>
        /// ACE �̃^�C�v��\���܂��B
        /// </summary>
        public byte  AceType;
        /// <summary>
        /// �p���Ɋւ���t���O��\���܂��B
        /// </summary>
        public byte  AceFlags;
        /// <summary>
        /// ACE �̃T�C�Y��\���܂��B
        /// </summary>
        public short AceSize;
    }


}