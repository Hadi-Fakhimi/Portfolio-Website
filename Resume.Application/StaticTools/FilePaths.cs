using System.IO;

namespace Resume.Application.StaticTools
{
    public static class FilePaths
    {
        #region Base Image Paths

        public static readonly string BaseImagePath = "/content/images/";
        public static readonly string BaseImagePathServer = $"wwwroot{BaseImagePath}";

        #endregion
        #region Default Image
        public static readonly string DefaultAvatar = $"{BaseImagePath}/default/default-avatar.png";

        #endregion

        #region Customer Feedback Avatar
        public static readonly string CustomerFeedbackAvatar = $"{BaseImagePath}/customer-feedback-avatar/origin/";
        public static readonly string CustomerFeedbackAvatarServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/customer-feedback-avatar/origin/");

        #endregion

        #region Customer Logo
        public static readonly string CustomerLogoImg = $"{BaseImagePath}/customer-logo/origin/";
        public static readonly string CustomerLogoImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/customer-logo/origin/");

        #endregion

        #region Portfolio
        public static readonly string PortfolioImg = $"{BaseImagePath}/portfolio/origin/";
        public static readonly string PortfolioImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/portfolio/origin/");

        #endregion

        #region Avatar
        public static readonly string AvatarImg = $"{BaseImagePath}/avatar/origin/";
        public static readonly string AvatarImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/avatar/origin/");


		#region UserAvatar

		public static readonly string UserAvatarImg = $"{BaseImagePath}/user-avatar/origin/";
		public static readonly string UserAvatarImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/user-avatar/origin/");
		#endregion

		#endregion

		#region Resume File
		public static readonly string Resume = $"{BaseImagePath}/resume/origin/";
        public static readonly string ResumeServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/resume/origin/");

        #endregion



        #region Resume File
        public static readonly string ThingIDoImg = $"{BaseImagePath}/thing/origin/";
        public static readonly string ThingIDoImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/thing/origin/");

        #endregion

        #region SiteAddress
        public static readonly string SiteAddress = "";

        #endregion
    }
}
