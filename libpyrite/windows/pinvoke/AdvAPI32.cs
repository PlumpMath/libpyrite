using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace pyrite.windows.pinvoke {


    using security;
    using services;


    /// <summary>
    ///
    /// </summary>
    public static class AdvAPI32 {
        /// <summary>
        /// �n���h���Ŏw�肳�ꂽ�I�u�W�F�N�g�̃Z�L�����e�B�L�q�q�̃R�s�[���擾���܂��B
        /// </summary>
        /// <param name="handle">�I�u�W�F�N�g�̃n���h���B</param>
        /// <param name="ObjectType">�I�u�W�F�N�g�^�C�v�B</param>
        /// <param name="SecurityInfo">�擾����Z�L�����e�B���̃^�C�v�B</param>
        /// <param name="pSidOwner">���L�� SID �ւ̃|�C���^���󂯎��B</param>
        /// <param name="pSidGroup">�v���C�}���O���[�v SID �ւ̃|�C���^���󂯎��B</param>
        /// <param name="pDacl">DACL �ւ̃|�C���^���󂯎��B</param>
        /// <param name="pSacl">SACL �ւ̃|�C���^���󂯎��B</param>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�ւ̃|�C���^�B</param>
        /// <returns>�����Ȃ� ERROR_SUCCESS ���Ԃ�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out IntPtr pDacl,
            out IntPtr pSacl,
            out IntPtr pSecurityDescriptor
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SecurityInfo"></param>
        /// <param name="pSidOwner"></param>
        /// <param name="pSidGroup"></param>
        /// <param name="pDacl"></param>
        /// <param name="pSacl"></param>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out IntPtr pDacl,
            out IntPtr pSacl,
            IntPtr pSecurityDescriptor
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SecurityInfo"></param>
        /// <param name="pSidOwner"></param>
        /// <param name="pSidGroup"></param>
        /// <param name="pDacl"></param>
        /// <param name="pSacl"></param>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out IntPtr pDacl,
            out IntPtr pSacl,
            out _SECURITY_DESCRIPTOR pSecurityDescriptor
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="ObjectType"></param>
        /// <param name="SecurityInfo"></param>
        /// <param name="pSidOwner"></param>
        /// <param name="pSidGroup"></param>
        /// <param name="pDacl"></param>
        /// <param name="pSacl"></param>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern uint GetSecurityInfo(
            IntPtr handle,
            SE_OBJECT_TYPE ObjectType,
            SECURITY_INFORMATION SecurityInfo,
            out IntPtr pSidOwner,
            out IntPtr pSidGroup,
            out _ACL pDacl,
            out _ACL pSacl,
            out _SECURITY_DESCRIPTOR pSecurityDescriptor
        );


        /// <summary>
        /// SID(�Z�L�����e�B ID)���A�\����i�[�A���M�ɓK����������֕ϊ����܂��B
        /// </summary>
        /// <param name="sid">�ϊ����� SID �ւ̃|�C���^�B</param>
        /// <param name="sidString">SID ������ւ̃|�C���^���󂯎��ϐ��ւ̃|�C���^�B</param>
        /// <returns>����������^�B</returns>
        [DllImport( "advapi32", SetLastError = true )]
        public static extern bool ConvertSidToStringSid(
            IntPtr sid,
            out IntPtr sidString
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="sidString"></param>
        /// <returns></returns>
        public static bool ConvertSidToStringSid(IntPtr sid, out string sidString) {
            IntPtr tmp_sid_string = IntPtr.Zero;
            bool result = ConvertSidToStringSid( sid, out tmp_sid_string );
            sidString = Marshal.PtrToStringAuto( tmp_sid_string );

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="sidString"></param>
        /// <returns></returns>
        [DllImport( "advapi32", SetLastError = true )]
        public static extern bool ConvertSidToStringSid(
            _SID sid,
            out IntPtr sidString
        );


        /// <summary>
        /// �V�����Z�L�����e�B�L�q�q�����������܂��B
        /// </summary>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�̃A�h���X�B</param>
        /// <param name="dwRevision">���r�W�������x���B</param>
        /// <returns>�����Ȃ�^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool InitializeSecurityDescriptor(IntPtr pSecurityDescriptor, uint dwRevision);
        /// <summary>
        ///  �V�����Z�L�����e�B�L�q�q�����������܂��B
        /// </summary>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�̃A�h���X�B</param>
        /// <returns>����������^�B</returns>
        public static bool InitializeSecurityDescriptor(IntPtr pSecurityDescriptor) {
            return InitializeSecurityDescriptor( pSecurityDescriptor, _SECURITY_DESCRIPTOR.REVISION );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="dwRevision"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool InitializeSecurityDescriptor(ref _SECURITY_DESCRIPTOR pSecurityDescriptor, uint dwRevision);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        public static bool InitializeSecurityDescriptor(ref _SECURITY_DESCRIPTOR pSecurityDescriptor) {
            return InitializeSecurityDescriptor( ref pSecurityDescriptor, _SECURITY_DESCRIPTOR.REVISION );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pacl"></param>
        /// <param name="nAclLength"></param>
        /// <param name="dwAclRevision"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool InitializeAcl(IntPtr pAcl, uint nAclLength, uint dwAclRevision);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pacl"></param>
        /// <param name="nAclLength"></param>
        /// <returns></returns>
        public static bool InitializeAcl(IntPtr pAcl, uint nAclLength) {
            return InitializeAcl( pAcl, nAclLength, _ACL.REVISION );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAcl"></param>
        /// <returns></returns>
        public static bool InitializeAcl(IntPtr pAcl) {
            return InitializeAcl( pAcl, _ACL.SizeOf, _ACL.REVISION );
        }


        /// <summary>
        /// �Z�L�����e�B�L�q�q�̃R���|�[�l���g���L�����ǂ����𒲂ׂ܂��B
        /// </summary>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�̃A�h���X�B</param>
        /// <returns>����������^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool IsValidSecurityDescriptor(IntPtr pSecurityDescriptor);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool IsValidSecurityDescriptor(_SECURITY_DESCRIPTOR pSecurityDescriptor);


        /// <summary>
        /// �\����L���ȍ\���̂̃T�C�Y���o�C�g�P�ʂŕԂ��܂��B
        /// </summary>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�̃A�h���X�B</param>
        /// <returns>SECURITY_DESCRIPTOR �\���̂̃o�C�g�P�ʂ̒����B</returns>
        [DllImport( "advapi32.dll" )]
        public static extern int GetSecurityDescriptorLength(IntPtr pSecurityDescriptor);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll" )]
        public static extern int GetSecurityDescriptorLength(_SECURITY_DESCRIPTOR pSecurityDescriptor);


        /// <summary>
        /// ACL(�A�N�Z�X���䃊�X�g)���̈�� ACE(�A�N�Z�X����G���g��)�ւ̃|�C���^���擾���܂��B
        /// </summary>
        /// <param name="aclPtr">�A�N�Z�X���䃊�X�g�ւ̃|�C���^�B</param>
        /// <param name="aceIndex">�擾���� ACE �̃C���f�b�N�X�ԍ��B</param>
        /// <param name="acePtr">ACE �ւ̃|�C���^�ւ̃|�C���^�B</param>
        /// <returns>����������^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAce(IntPtr aclPtr, int aceIndex, out IntPtr acePtr);


        /// <summary>
        /// ACL(�A�N�Z�X���䃊�X�g)�Ɋւ�������擾���܂��B
        /// </summary>
        /// <param name="pAcl">�A�N�Z�X���䃊�X�g�ւ̃|�C���^�B</param>
        /// <param name="pAclInfomation"></param>
        /// <param name="nAclInfomationLength"></param>
        /// <param name="dwAclInfomationClass"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAclInformation(
            IntPtr pAcl,
            IntPtr pAclInformation,
            uint nAclInformationLength,
            ACL_INFORMATION_CLASS dwAclInformationClass
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAcl"></param>
        /// <param name="pAclInformation"></param>
        /// <param name="nAclInformationLength"></param>
        /// <param name="dwAclInformationClass"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAclInformation(
            IntPtr pAcl,
            ref _ACL_REVISION_INFORMATION pAclInformation,
            uint nAclInformationLength,
            ACL_INFORMATION_CLASS dwAclInformationClass
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pAcl"></param>
        /// <param name="pAclInformation"></param>
        /// <param name="nAclInformationLength"></param>
        /// <param name="dwAclInformationClass"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetAclInformation(
            IntPtr pAcl,
            ref _ACL_SIZE_INFORMATION pAclInformation,
            uint nAclInformationLength,
            ACL_INFORMATION_CLASS dwAclInformationClass
        );


        /// <summary>
        /// �t�@�C���܂��̓f�B���N�g���Ɋւ���A�w�肳�ꂽ�����擾���܂��B
        /// </summary>
        /// <param name="lpFileName">�t�@�C�����B</param>
        /// <param name="requestedInfomation">�擾������B</param>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�̃A�h���X�B</param>
        /// <param name="nLength">�Z�L�����e�B�L�q�q�o�b�t�@�̃T�C�Y�B</param>
        /// <param name="lpnLengthNeeded">�o�b�t�@���K�v�Ƃ���T�C�Y��ێ�����A�h���X�B</param>
        /// <returns>��������ΐ^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetFileSecurity(
            string lpFileName,
            SECURITY_INFORMATION requestedInfomation,
            IntPtr pSecurityDescriptor,
            uint nLength,
            out uint lpnLengthNeeded
        );
        /// <summary>
        /// �t�@�C���܂��̓f�B���N�g���Ɋւ���A�w�肳�ꂽ�����擾���܂��B
        /// </summary>
        /// <param name="lpFileName">�t�@�C�����B</param>
        /// <param name="requestedInfomation">�擾������B</param>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�B</param>
        /// <param name="nLength">�Z�L�����e�B�L�q�q�o�b�t�@�̃T�C�Y�B</param>
        /// <param name="lpnLengthNeeded">�o�b�t�@���K�v�Ƃ���T�C�Y��ێ�����A�h���X�B</param>
        /// <returns>��������ΐ^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetFileSecurity(
            string lpFileName,
            SECURITY_INFORMATION requestedInfomation,
            [MarshalAs( UnmanagedType.Struct )] ref _SECURITY_DESCRIPTOR pSecurityDescriptor,
            uint nLength,
            out uint lpnLengthNeeded
        );


        /// <summary>
        /// �w�肳�ꂽ�Z�L�����e�B�L�q�q���� DACL(���ӃA�N�Z�X���䃊�X�g)�ւ̃|�C���^���擾���܂��B
        /// </summary>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�̃A�h���X�B</param>
        /// <param name="lpbDaclPresent">DACL �����݂��邱�Ƃ������t���O�ւ̃A�h���X�B</param>
        /// <param name="pDacl">ACL �ւ̃|�C���^�̃A�h���X�B</param>
        /// <param name="lpbDaclDefaulted">DACL ������̂��̂��ǂ����������t���O�̃A�h���X�B</param>
        /// <returns>��������ΐ^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorDacl(
            IntPtr pSecurityDescriptor,
            ref bool lpbDaclPresent,
            out IntPtr pDacl,
            ref bool lpbDaclDefaulted
        );


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="lpbSaclPresent"></param>
        /// <param name="pSacl"></param>
        /// <param name="lpbSaclDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorSacl(
            IntPtr pSecurityDescriptor,
            ref bool lpbSaclPresent,
            out IntPtr pSacl,
            ref bool lpbSaclDefaulted
        );


        /// <summary>
        /// �Z�L�����e�B�L�q�q���珊�L�ҏ����擾���܂��B
        /// </summary>
        /// <param name="pSecurityDescriptor">�Z�L�����e�B�L�q�q�̃A�h���X�B</param>
        /// <param name="pOwner">���L�҂� SID�ւ̃|�C���^�̃A�h���X�B</param>
        /// <param name="lpbOwnerDefaulted">���肩�ǂ����������t���O�̃A�h���X�B</param>
        /// <returns>����������^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            IntPtr pSecurityDescriptor,
            [MarshalAs( UnmanagedType.LPArray )] byte[] pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            _SECURITY_DESCRIPTOR pSecurityDescriptor,
            [MarshalAs( UnmanagedType.LPArray )] byte[] pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            IntPtr pSecurityDescriptor,
            out object pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            IntPtr pSecurityDescriptor,
            out IntPtr pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            _SECURITY_DESCRIPTOR pSecurityDescriptor,
            out object pOwner,
            ref bool lpbOwnerDefaulted
        );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pOwner"></param>
        /// <param name="lpbOwnerDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorOwner(
            _SECURITY_DESCRIPTOR pSecurityDescriptor,
            out IntPtr pOwner,
            ref bool lpbOwnerDefaulted
        );


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSecurityDescriptor"></param>
        /// <param name="pGroup"></param>
        /// <param name="lpbGroupDefaulted"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool GetSecurityDescriptorGroup(
            IntPtr pSecurityDescriptor,
            out IntPtr pGroup,
            ref bool lpbGroupDefaulted
        );


        /// <summary>
        /// 
        /// </summary>
        /// <param name="lpSystemName"></param>
        /// <param name="Sid"></param>
        /// <param name="lpName"></param>
        /// <param name="cchName"></param>
        /// <param name="lpReferencedDomainName"></param>
        /// <param name="cchReferencedDomainName"></param>
        /// <param name="peUse"></param>
        /// <returns></returns>
        [DllImport( "advapi32.dll", SetLastError = true, CharSet = CharSet.Auto )]
        public static extern bool LookupAccountSid(
            string lpSystemName,
            IntPtr Sid,
            [Out] StringBuilder lpName,
            out uint cchName,
            [Out] StringBuilder lpReferencedDomainName,
            out uint cchReferencedDomainName,
            ref SID_NAME_USE peUse
        );
        /// <summary>
        /// SID �ɑΉ�����A�J�E���g�̖��O�Ƃ��� SID �����������ŏ��̃h���C�����擾���܂��B
        /// </summary>
        /// <param name="lpSystemName">���[�J���A�܂��̓����[�g�R���s���[�^���B</param>
        /// <param name="Sid">�Q�Ƃ��� SID�B</param>
        /// <param name="lpName">�A�J�E���g���󂯎��o�b�t�@�B</param>
        /// <param name="cchName">�A�J�E���g���o�b�t�@�̃T�C�Y�B</param>
        /// <param name="ReferencedDomainName">�Q�Ƃ����h���C���̖��O���󂯎��o�b�t�@�B</param>
        /// <param name="cchReferencedDomainName">�h���C�����o�b�t�@�̃T�C�Y�B</param>
        /// <param name="peUse">SID �̃^�C�v���󂯎��܂��B</param>
        /// <returns>����������^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true, CharSet = CharSet.Auto )]
        public static extern bool LookupAccountSid(
            string lpSystemName,
            [MarshalAs( UnmanagedType.LPArray )] byte[] Sid,
            [Out] StringBuilder lpName,
            out uint cchName,
            [Out] StringBuilder lpReferencedDomainName,
            out uint cchReferencedDomainName,
            ref SID_NAME_USE peUse
        );


        /// <summary>
        /// �Ăяo�����T�[�r�X�Ɋւ���T�[�r�X����}�l�[�W���̃X�e�[�^�X�����X�V���܂��B
        /// </summary>
        /// <param name="hServiceStatus">���݂̃T�[�r�X�ɑΉ�����X�e�[�^�X���\���̂̃n���h���B</param>
        /// <param name="lpServiceStatus">�Ăяo�����T�[�r�X�Ɋւ���ŐV�X�e�[�^�X�����i�[����\���̂ւ̎Q�ƁB</param>
        /// <returns>��������ΐ^�B</returns>
        [DllImport( "advapi32.dll", SetLastError = true, CharSet = CharSet.Auto )]
        public static extern bool SetServiceStatus(IntPtr hServiceStatus, ref SERVICE_STATUS lpServiceStatus);
    }


}
