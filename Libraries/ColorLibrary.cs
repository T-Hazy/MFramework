using UnityEngine;

namespace MFramework.UtilityLibrary
{
    ///https://www.codeeeee.com/color/rgb.html
    public static class ColorLibrary
    {
        /// <summary>
        /// 红色
        /// </summary>
        public static Color Red => Color.red;

        /// <summary>
        /// 绿色
        /// </summary>
        public static Color Green => Color.green;

        /// <summary>
        /// 蓝色
        /// </summary>
        public static Color Blue => Color.blue;

        /// <summary>
        /// 黄色
        /// </summary>
        public static Color Yellow => Color.yellow;

        /// <summary>
        /// 紫色
        /// </summary>
        public static Color Purple => new Color(0.5f, 0f, 0.5f);

        /// <summary>
        /// 青色
        /// </summary>
        public static Color Cyan => Color.cyan;

        /// <summary>
        /// 白色
        /// </summary>
        public static Color White => Color.white;

        /// <summary>
        /// 黑色
        /// </summary>
        public static Color Black => Color.black;

        /// <summary>
        /// 灰色
        /// </summary>
        public static Color Gray => Color.gray;

        /// <summary>
        /// 品红色
        /// </summary>
        public static Color Magenta => Color.magenta;

        /// <summary>
        /// 橘色
        /// </summary>
        public static Color Orange => Color.HSVToRGB(0.05f, 1f, 1f);

        /// <summary>
        /// 棕色
        /// </summary>
        public static Color Brown => Color.HSVToRGB(0.05f, 0.5f, 0.5f);

        /// <summary>
        /// 粉红色
        /// </summary>
        public static Color Pink => Color.HSVToRGB(0.1f, 0.4f, 1f);

        /// <summary>
        /// 浅蓝色
        /// </summary>
        public static Color LightBlue => new Color(0.1f, 0.5f, 0.7f);

        /// <summary>
        /// 透明色
        /// </summary>
        public static Color Transparent => Color.clear;


        /// <summary>
        /// 雪白
        /// </summary>
        public static Color Snow => ConvertUnityColor(255, 250, 250);

        /// <summary>
        /// 幽灵白
        /// </summary>
        public static Color GhostWhite => ConvertUnityColor(248, 248, 255);

        /// <summary>
        /// 烟雾白
        /// </summary>
        public static Color WhiteSmoke => ConvertUnityColor(245, 245, 245);

        /// <summary>
        /// 亮灰色
        /// </summary>
        public static Color Gainsboro => ConvertUnityColor(220, 220, 220);

        /// <summary>
        /// 花白
        /// </summary>
        public static Color FloralWhite => ConvertUnityColor(255, 250, 240);

        /// <summary>
        /// 老花色
        /// </summary>
        public static Color OldLace => ConvertUnityColor(253, 245, 230);

        /// <summary>
        /// 亚麻色
        /// </summary>
        public static Color Linen => ConvertUnityColor(250, 240, 230);

        /// <summary>
        /// 古董白
        /// </summary>
        public static Color AntiqueWhite => ConvertUnityColor(250, 235, 215);

        /// <summary>
        /// 木瓜鞭
        /// </summary>
        public static Color PapayaWhip => ConvertUnityColor(255, 239, 213);

        /// <summary>
        /// 杏仁色
        /// </summary>
        public static Color BlanchedAlmond => ConvertUnityColor(255, 239, 205);

        /// <summary>
        /// 橘黄色
        /// </summary>
        public static Color Bisque => ConvertUnityColor(255, 228, 196);

        /// <summary>
        /// 桃色
        /// </summary>
        public static Color PeachPuff => ConvertUnityColor(255, 218, 185);

        /// <summary>
        /// 纳瓦白
        /// </summary>
        public static Color NavajoWhite => ConvertUnityColor(255, 222, 173);

        /// <summary>
        /// 鹿皮鞋色
        /// </summary>
        public static Color Moccasin => ConvertUnityColor(255, 228, 181);

        /// <summary>
        /// 米绸色
        /// </summary>
        public static Color Cornsilk => ConvertUnityColor(255, 248, 220);

        /// <summary>
        /// 象牙白
        /// </summary>
        public static Color Ivory => ConvertUnityColor(255, 255, 240);

        /// <summary>
        /// 柠檬绸色
        /// </summary>
        public static Color LemonChiffon => ConvertUnityColor(255, 250, 205);

        /// <summary>
        /// 贝壳粉
        /// </summary>
        public static Color Seashell => ConvertUnityColor(255, 245, 238);

        /// <summary>
        /// 蜜瓜绿
        /// </summary>
        public static Color Honeydew => ConvertUnityColor(240, 255, 240);

        /// <summary>
        /// 天青色
        /// </summary>
        public static Color Azure => ConvertUnityColor(240, 255, 255);

        /// <summary>
        /// 艾丽斯蓝
        /// </summary>
        public static Color AliceBlue => ConvertUnityColor(240, 248, 255);

        /// <summary>
        /// 薰衣草紫
        /// </summary>
        public static Color Lavender => ConvertUnityColor(230, 230, 250);

        /// <summary>
        /// 淡紫红
        /// </summary>
        public static Color LavenderBlush => ConvertUnityColor(255, 240, 245);

        /// <summary>
        /// 雾玫瑰色
        /// </summary>
        public static Color MistyRose => ConvertUnityColor(255, 228, 225);


        /// <summary>
        /// 暗灰色
        /// </summary>
        public static Color DimGrey => ConvertUnityColor(105, 105, 105);

        /// <summary>
        /// 深石板灰
        /// </summary>
        public static Color DarkSlateGray => ConvertUnityColor(47, 79, 79);

        /// <summary>
        /// 石板灰
        /// </summary>
        public static Color SlateGrey => ConvertUnityColor(112, 128, 144);

        /// <summary>
        /// 浅石板灰
        /// </summary>
        public static Color LightSlateGray => ConvertUnityColor(112, 128, 144);

        /// <summary>
        /// 灰色
        /// </summary>
        public static Color Grey => ConvertUnityColor(190, 190, 190);

        /// <summary>
        /// 浅灰色
        /// </summary>
        public static Color LightGray => ConvertUnityColor(190, 190, 190);

        /// <summary>
        /// 深蓝色
        /// </summary>
        public static Color MidnightBlue => ConvertUnityColor(25, 25, 112);

        /// <summary>
        /// 海军蓝
        /// </summary>
        public static Color NavyBlue => ConvertUnityColor(0, 0, 128);

        /// <summary>
        /// 矢车菊蓝
        /// </summary>
        public static Color CornflowerBlue => ConvertUnityColor(100, 149, 237);

        /// <summary>
        /// 暗灰蓝
        /// </summary>
        public static Color DarkSlateBlue => ConvertUnityColor(72, 61, 139);

        /// <summary>
        /// 石板蓝
        /// </summary>
        public static Color SlateBlue => ConvertUnityColor(106, 90, 205);

        /// <summary>
        /// 间石板蓝
        /// </summary>
        public static Color MediumSlateBlue => ConvertUnityColor(123, 104, 238);

        /// <summary>
        /// 浅石板蓝
        /// </summary>
        public static Color LightSlateBlue => ConvertUnityColor(132, 112, 255);

        /// <summary>
        /// 中蓝色
        /// </summary>
        public static Color MediumBlue => ConvertUnityColor(0, 0, 205);

        /// <summary>
        /// 皇家蓝
        /// </summary>
        public static Color RoyalBlue => ConvertUnityColor(65, 105, 225);

        /// <summary>
        /// 闪蓝色(道奇蓝)
        /// </summary>
        public static Color DodgerBlue => ConvertUnityColor(30, 144, 255);

        /// <summary>
        /// 深空蓝
        /// </summary>
        public static Color DeepSkyBlue => ConvertUnityColor(0, 191, 235);

        /// <summary>
        /// 天蓝色
        /// </summary>
        public static Color SkyBlue => ConvertUnityColor(135, 206, 235);

        /// <summary>
        /// 浅天蓝
        /// </summary>
        public static Color LightSkyBlue => ConvertUnityColor(135, 206, 250);

        /// <summary>
        /// 铁青色
        /// </summary>
        public static Color SteelBlue => ConvertUnityColor(70, 130, 180);

        /// <summary>
        /// 浅铁青色
        /// </summary>
        public static Color LightSteelBlue => ConvertUnityColor(176, 196, 222);

        /// <summary>
        /// 粉蓝色
        /// </summary>
        public static Color PowderBlue => ConvertUnityColor(176, 224, 230);

        /// <summary>
        /// 浅宝石绿
        /// </summary>
        public static Color PaleTurquoise => ConvertUnityColor(175, 238, 238);

        /// <summary>
        /// 暗宝石绿
        /// </summary>
        public static Color DarkTurquoise => ConvertUnityColor(0, 206, 209);

        /// <summary>
        /// 中宝石绿
        /// </summary>
        public static Color MediumTurquoise => ConvertUnityColor(72, 209, 204);

        /// <summary>
        /// 宝石绿
        /// </summary>
        public static Color Turquoise => ConvertUnityColor(72, 209, 204);

        /// <summary>
        /// 淡青色
        /// </summary>
        public static Color LightCyan => ConvertUnityColor(224, 255, 255);

        /// <summary>
        /// 军绿色
        /// </summary>
        public static Color CadetBlue => ConvertUnityColor(95, 158, 160);

        /// <summary>
        /// 间绿色
        /// </summary>
        public static Color MediumAquamarine => ConvertUnityColor(102, 205, 170);

        /// <summary>
        /// 海宝石蓝
        /// </summary>
        public static Color Aquamarine => ConvertUnityColor(127, 255, 212);

        /// <summary>
        /// 深绿色
        /// </summary>
        public static Color DarkGreen => ConvertUnityColor(0, 100, 0);

        /// <summary>
        /// 深橄榄绿
        /// </summary>
        public static Color DarkOliveGreen => ConvertUnityColor(85, 107, 47);

        /// <summary>
        /// 深海绿
        /// </summary>
        public static Color DarkSeaGreen => ConvertUnityColor(143, 188, 143);

        /// <summary>
        /// 海绿色
        /// </summary>
        public static Color SeaGreen => ConvertUnityColor(46, 139, 87);

        /// <summary>
        /// 中海绿
        /// </summary>
        public static Color MediumSeaGreen => ConvertUnityColor(60, 179, 113);

        /// <summary>
        /// 浅海绿
        /// </summary>
        public static Color LightSeaGreen => ConvertUnityColor(32, 178, 170);

        /// <summary>
        /// 浅绿色
        /// </summary>
        public static Color PaleGreen => ConvertUnityColor(152, 251, 152);

        /// <summary>
        /// 春绿色
        /// </summary>
        public static Color SpringGreen => ConvertUnityColor(0, 255, 127);

        /// <summary>
        /// 草坪绿
        /// </summary>
        public static Color LawnGreen => ConvertUnityColor(124, 252, 0);

        /// <summary>
        /// 黄绿色
        /// </summary>
        public static Color Chartreuse => ConvertUnityColor(127, 255, 0);

        /// <summary>
        /// 地中海春绿
        /// </summary>
        public static Color MedSpringGreen => ConvertUnityColor(0, 250, 154);

        public static Color GrayPercentage(float percentage, float alpha = 1) =>
            new Color(percentage, percentage, percentage, alpha);

        private static Color ConvertUnityColor(int r, int g, int b, float alpha = 1) =>
            new Color(r / 255f, g / 255f, b / 255f, alpha);
    }
}