using _1104001期末.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _1104001期末.Pages
{
    public class DetailModel : PageModel
    {
        public Zeitgeist CharacterData { get; set; } = new Zeitgeist();

        public void OnGet(int id)
        {
            var mockData = new List<Zeitgeist>
            {
                new Zeitgeist { Id = 1, Name = "源（Ori）", Sephirot = "王冠|Kether", Quote = "­ÌÈÈôÃüß\\ÅcÑ­­hÊÇÄãÍý\u0088D¶ó\u009a¢µÄ¡¢Éñ±³Ø\u0093µÄ×ï¡ª¡ªÄã±ãÊÇ×ï\u0090ºµÄÆðÔ´¡£" ,ImagePath = "/images/ori.png", Story = "叫醒了世，成為了世的搭檔，與其一起探索世界，並試圖從世身上尋求世界真相的神祕少年。\r\n\r\n能力是能使用護罩將核心或花瓣中的\"汙穢\"分離出來，被披風的黑洞吸收和讀取，然後將這些能量轉化成自身的\"知識\"。\r\n\r\n在劇外互動時會離大家遠遠的，但目光都會悄悄地放在世身上，\r\n有人出事的時候也會適時提供協助。", Gallery = "/images/ori1.png,/images/ori2.png,/images/ori1.png,/images/ori3.png"},

                new Zeitgeist { Id = 2, Name = "思（Ide）", Sephirot = "智慧|Chokmah", Quote = "我看透命運，我聽見真理，世界上從來沒有我無法理解透徹的事物；但一顆閃爍的星除了為虛空點綴和引導人們，並不能取代整個宇宙。" ,ImagePath = "/images/ide.png", Story = "\r\n人們自我意識與思考的起點，司掌黃道與知性，喜歡透過移動星星和天體去引導靈魂。\r\n\r\n由於特殊體質使得自身行動不便，但具有靈活且邏輯清晰的頭腦。他曾經瞥到了一眼所謂的真相，但除了引導，什麼都做不了。\r\n\r\n在劇外互動時喜歡替生和夢出些整人的主意，然後再看他們被反整或挨揍。(?)", Gallery = "/images/ide1.png,/images/ide2.png"},

                new Zeitgeist { Id = 3, Name = "時（Chron）", Sephirot = "理解|Binah", Quote = "追溯遙遠的時空，理解命運的軌跡，直到真相所在之處，直到時間盡頭，為變數帶來決心。" ,ImagePath = "/images/chron.jpg", Story = "人們對時間流逝以及感情的認知起源，司掌時間與情緒。\r\n\r\n喜歡閱讀和記錄來自不同時空或世界的記憶，並且將其凝聚成各種物體，包括但不限於透明珠子或筆記本。\r\n\r\n自稱原本只是為學習無數知識與思想而誕生的人偶，只是在閱讀無數記憶後誕生自我。\r\n\r\n在劇外互動時被其他核心敬重，但她其實不介意其他人接近她。\r\n與思最親密且常常一起出現。", Gallery = "/images/chron1.jpg,/images/chron2.png,/images/chron3.png"},

                new Zeitgeist { Id = 4, Name = "愛（Philo）", Sephirot = "慈悲|Chesed", Quote = "由深海中誕生，你生來便背負治癒的使命，於是，竭盡全力地治療傷痛成為你的責任；但，生與死，對你來說又意味著什麼呢？" ,ImagePath = "/images/philo.png", Story = "居住於潮濕的服務殿堂，司掌聖水與恩賜，\r\n掌控大自然中水的百態。\r\n\r\n脾氣很好的老好人，也出了名的心軟，但是拯救或幫助不了人時會很自責。\r\n\r\n他為自己擬造了一個小男孩的形象，與他內心有無法抹滅但刻意遺忘的傷痕有關聯。\r\n但此型態的他，仍擁有不可小瞧的戰力與智力。\r\n\r\n劇外互動中是全核心最矮，但實際戰力與力不相上下。", Gallery = "/images/philo1.png,/images/philo2.png"},

                new Zeitgeist { Id = 5, Name = "力（Dyna）", Sephirot = "嚴厲|Genurah", Quote = "當你的手上已經沾染無數鮮血，當你的火焰已將所有敵人燃成灰燼...當你站在屍骨之上，你是否懷疑過，不斷的戰鬥與審判究竟是為了什麼？" ,ImagePath = "/images/dyna.png", Story = "在炎熱的淨化殿堂裡修練，司掌聖火與審判，\r\n掌控火焰與僅次於源的強大戰力。\r\n\r\n性格強勢且非常具有主見，喜歡透過花瓣找記憶中的生物戰鬥，覺得戰鬥令人身心舒暢，也能修煉自我。\r\n儘管沉迷戰鬥時的正義感和自信，但結束了之後會陷入極度的空虛。\r\n\r\n意外地非常擅長料理。\r\n\r\n劇外互動中因不服過度善良的愛而常常挑戰愛，\r\n事實上卻又喜歡跟著愛一起行動。", Gallery = "/images/dyna1.png,/images/dyna2.png"},

                new Zeitgeist { Id = 6, Name = "光（Luc）", Sephirot = "美麗|Tiphereth", Quote = "極端無盡，無夜的永晝。天上的太陽為杜絕世間的紛爭與陰謀，在無數的鏡面中永恆地焚燒自我。" ,ImagePath = "/images/luc.png", Story = "居住於永晝的再生殿堂，司掌陽光、能量與和諧。\r\n擁有美麗的外貌與自信驕傲的談吐，以自身的領導氣質履行調解紛爭或不平衡的使命。\r\n\r\n劇外互動中是令核心願意專心聽他說話的決策者，但本人表示只對源獻上絕對的忠誠。\r\n有時會對無盡的永晝感到疲憊，所以偶爾也喜歡去夢永夜的夢境殿堂坐坐。", Gallery = "/images/luc1.png,/images/luc2.png,/images/luc3.png"},

                new Zeitgeist { Id = 7, Name = "生（Bio）", Sephirot = "勝利|Netzach", Quote = "創造的盡頭是虛無，但我們仍然要創造呀。我們不斷地枯萎，但也不斷地發芽茁壯，因為生命的每個過程都是一副獨特而美麗的樣貌。" ,ImagePath = "/images/bio.png", Story = "在長滿植物的藝術殿堂甦醒，司掌生命與藝術，能夠透過手上的畫筆，憑空繪出大自然中有生命的物體。\r\n腦中有無限的靈感和想法，也造就了他鬼靈精怪的性格。\r\n\r\n曾經因看到萬物枯竭的景象，而差點粉碎他那純真又富有想像力的靈魂。\r\n\r\n身邊有名為\"小提燈\"的奇妙生物，會發光且有自我認知。\r\n\r\n劇外互動中喜歡捉弄特定核心，譬如力和理。\r\n希望理能夠因為自己的捉弄而學會表達情緒，盡管理常常不領情，他也從不放棄。", Gallery = "/images/bio1.png,/images/bio2.png"},

                new Zeitgeist { Id = 8, Name = "理（Sci）", Sephirot = "榮耀|Hod", Quote = "抱歉，我只信奉純粹的數據與指令。情感此種災難且不可控之物，只消拋棄便可避免一切不穩定之變數，避免重蹈翠綠的犧牲。" ,ImagePath = "/images/sci.png", Story = "在環繞氣流與沙土的科學殿堂研習，司掌文字與科學，能夠透過對某些知識的精通來使出對應的力量，較常使用的是沙塵暴和龍捲風。\r\n\r\n知性、冷漠且講求科學與規則，甚至認為情感妨礙學習。\r\n喜歡以楓葉堅毅和積極進取的象徵來鞭策自己。\r\n\r\n一開始是最弱勢的質點，憑藉求知的熱愛而習得許多知識。\r\n但有時也會碰到難以解決的謎題：譬如情感相關的問題。\r\n\r\n劇外互動中常教導生用文字溝通以及植物生長條件的知識，\r\n但自己不願接受生的幫助，認為情感妨礙學習。\r\n後來認知到自己所學到的規則與道理，都是源自生的存在，才逐漸不排斥生。", Gallery = "/images/sci1.png,/images/sci2.png"},

                new Zeitgeist { Id = 9, Name = "夢（Somn）", Sephirot = "基礎|Yesod", Quote = "極端無盡，無光的黑夜。噩夢的柴郡貓，邀請魎魅魍魑一同於月下狂亂共舞，以客人的驚嚇與驚喜為樂。" ,ImagePath = "/images/somn.png", Story = "在永夜的夢境殿堂中遊玩，司掌電流與魔法、精神的一系列超自然現象，已知能夠為任何物體賦予靈魂。\r\n\r\n充滿各種妖魔鬼怪和各種夢境的夜之世界，造就了他非常的精明頑皮，但認真起來時卻又非常雷厲風行的性格。\r\n\r\n劇外互動中喜歡和生以及思一起整核心們。\r\n因為接觸永夜太久會使人癲狂，所以夢喜歡躲到光那裏。", Gallery = "/images/somn1.png,/images/somn2.png,/images/somn3.png"},

                new Zeitgeist { Id = 10, Name = "世（Cosm）", Sephirot = "王國|Malkuth", Quote = "你名為世，甦醒於世界最美妙的中心；你是被神愛著的孩子，只要知道這點就好了。" ,ImagePath = "/images/cosm.png", Story = "在大地殿堂甦醒，\r\n並且因好奇而與源啟程探索世界與認識其他核心。\r\n\r\n雖然目前沒有司掌任何東西，但她可以利用桃紅花瓣帶來的相關正面經驗，將正向的情緒和言語感染核心，讓核心暴露潛藏在自己身上的\"汙穢\"。\r\n\r\n\"她是世界的寵兒，只會接觸美好的事物，享受人世帶來的幸福與希望，她眼中的世界是最為繽紛美妙的。\"\r\n\r\n\"但總有一天，她也會查覺到一切的不對勁。\"\r\n\"她將透過她的搭檔源窺見世界的另一面，然後真正意義上的覺醒......\"\r\n\r\n\r\n劇外互動是所有核心的群寵，被大家當作親妹妹疼愛，但跟源的關係最好。", Gallery = "/images/cosm1.png,/images/cosm2.png,/images/cosm3.png"}
            };

            CharacterData = mockData.FirstOrDefault(c => c.Id == id);
        }
    }
}
   
