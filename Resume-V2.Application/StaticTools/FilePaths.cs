using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.StaticTools
{
    public class FilePaths
    {
        #region Base Image Paths
        public static readonly string BasePdfPath = "/content/pdf";
        public static readonly string BaseImagePath = "/content/images";
        public static readonly string BaseImagePathServer = $"wwwroot{BaseImagePath}";

        #endregion
        #region Default Image
        public static readonly string DefaultAvatar = $"{BaseImagePath}/default/origin/default-avatar.png";

        #endregion

        #region UserAvatar

        public static readonly string UserAvatarImg = $"{BaseImagePath}/user-avatar/origin/";
        public static readonly string UserAvatarImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/user-avatar/origin/");
        #endregion

        #region PortfolioImage

        public static readonly string PortfolioImg = $"{BaseImagePath}/portfolio-image/origin/";
        public static readonly string PortfolioImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/portfolio-image/origin/");
        #endregion

        #region CustomerFeedbackImage

        public static readonly string CustomerFeedbackImg = $"{BaseImagePath}/customerFeedback-image/origin/";
        public static readonly string CustomerFeedbackImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/customerFeedback-image/origin/");
        #endregion

        #region CustomerLogoImage

        public static readonly string CustomerLogoImg = $"{BaseImagePath}/customerLogo-image/origin/";
        public static readonly string CustomerLogoImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/customerLogo-image/origin/");
        #endregion

        #region BlogImage

        public static readonly string BlogImg = $"{BaseImagePath}/blog-image/origin/";
        public static readonly string BlogImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/blog-image/origin/");
        #endregion
        #region BlogPage1Image

        public static readonly string BlogPage1Img = $"{BaseImagePath}/blog-page-image-1/origin/";
        public static readonly string BlogPage1ImgServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/blog-page-image-1/origin/");
        #endregion
        #region BlogPage2Image

        public static readonly string BlogPage2Img = $"{BaseImagePath}/blog-page-image-2/origin/";
        public static readonly string BlogPage2Server = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/blog-page-image-2/origin/");
        #endregion

        #region PortfolioPageImage

        public static readonly string PortfolioPage1Img = $"{BaseImagePath}/portfolio-page-image-1/origin/";
        public static readonly string PortfolioPage1Server = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/portfolio-page-image-1/origin/");
        #endregion

        #region CV
        public static readonly string CvPdf = $"{BasePdfPath}/origin/";
        public static readonly string CvPdfServer = Path.Combine(Directory.GetCurrentDirectory(), $"{BaseImagePathServer}/pdf/origin/");
        #endregion

        #region Site Address
        public static readonly string SiteAddress = "https://localhost:7153";
        #endregion
    }
}
