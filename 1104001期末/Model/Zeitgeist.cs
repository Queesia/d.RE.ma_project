namespace _1104001期末.Model
{
    public class Zeitgeist
    {
        public int Id { get; set; } // 查詢用
        public string Name { get; set; } = "";
        public string Sephirot { get; set; } = ""; // 質點
        public string Quote { get; set; } = ""; // 用於體現角色性格的語錄
        public string ImagePath { get; set; } = ""; // 頭像
        public string Story { get; set; } = ""; // 小故事
        public string Gallery { get; set; } = ""; //圖片庫
    }
}
