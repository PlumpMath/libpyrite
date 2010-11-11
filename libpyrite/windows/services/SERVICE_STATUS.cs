using System.Runtime.InteropServices;


namespace pyrite.windows.services {


    /// <summary>
    /// �T�[�r�X�̏�Ԃ� SCM �ɕ񍐂��邽�߂̍\���̂ł��B
    /// </summary>
    [StructLayout( LayoutKind.Sequential )]
    public struct SERVICE_STATUS {
        /// <summary>
        /// SERVICE_STATUS �\���̂̃T�C�Y�ł��B
        /// </summary>
        public static readonly int SizeOf = Marshal.SizeOf( typeof( SERVICE_STATUS ) );
        
        
        /// <summary>
        /// �Ή�����T�[�r�X���ǂ̂悤�ȃT�[�r�X�ł��邩��\���܂��B
        /// </summary>
        public SERVICE_TYPE serviceType;
        /// <summary>
        /// �Ή�����T�[�r�X�̌��݂̏�Ԃ�\���܂��B
        /// </summary>
        public SERVICE_STATE currentState;
        /// <summary>
        /// SCM �����M����������R�[�h���r�b�g�t�B�[���h�Ŏw�肵�܂��B
        /// </summary>
        public SERVICE_CONTROLS_ACCEPT controlsAccepted;
        /// <summary>
        /// �T�[�r�X�̊J�n���A�������̓T�[�r�X�̒�~���ɃG���[���������Ă��܂��A
        /// ���ۂɏ������s�����Ƃ��ł��Ȃ��ꍇ�̃G���[�R�[�h���w�肵�܂��B
        /// </summary>
        public uint win32ExitCode;
        /// <summary>
        /// �I���W�i���̃G���[�R�[�h���w�肵�܂��B
        /// </summary>
        /// <remarks>
        /// Win32 �̃G���[�R�[�h�ł͂Ȃ��A�I���W�i���̃G���[�R�[�h��񍐂������悤�ȏꍇ�A
        /// win32ExitCode �� ERROR_SERCICE_SPECIFIC_ERROR ���w�肷�邱�Ƃɂ��A
        /// serviceSpecificExitCode �ɃI���W�i���̃G���[�R�[�h���w��ł��܂��B
        /// </remarks>
        public uint serviceSpecificExitCode;
        /// <summary>
        /// 
        /// </summary>
        public uint checkPoint;
        /// <summary>
        /// 
        /// </summary>
        public uint waitHint;
    }


}
