namespace Cinemo.Utils {
  public class FormatString {
    public static string Trim_MultiSpaces_Title(string str) {
      //Xoá các khoảng trắng đầu cuối
      str = str.Trim();
      //Thay thế nhiều khoảng trắng thành 1 khoảng trắng
      str = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ");
      //In hoa chữ cái đầu của mỗi từ
      str = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
      return str;
    }
  }
}