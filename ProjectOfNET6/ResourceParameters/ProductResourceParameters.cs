using System.Text.RegularExpressions;

namespace ProjectOfNET6.ResourceParameters
{
    public class ProductResourceParameters
    {
        public string? Keyword { get; set; }
        public string? RatingOperator { get; set; }
        public int? RatingValue { get; set; }
        private string _rating;
        public string? Rating
        {
            get { return _rating; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) //避免前端傳入null or空值 導致正則表達式Match報錯
                {
                    Regex regex = new Regex(@"([A-Za-z0-9\-]+)(\d+)"); //代表分成兩部分來拆，前面為英數字，後面為十進位數字，+號代表匹配多次
                                                                       //且英數字和十進位數字要緊連一起，才算符合此pattern
                    Match match = regex.Match(value);
                    if (match.Success)
                    {
                        RatingOperator = match.Groups[1].Value; //Group分組的數值會從index=1開始，因為index=0是儲存整個匹配完的字串
                        RatingValue = int.Parse(match.Groups[2].Value);
                    }
                    _rating = value;
                }
            }
        }

    }
}
