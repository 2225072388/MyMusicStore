using MusicStoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace MusicStore.Migrations
{
    public class GenreSeed
    {
        private static readonly MusicStoreEntity.EntityDbContext _dbcontext = new MusicStoreEntity.EntityDbContext();
        public static void Seed()
        {
            _dbcontext.Database.ExecuteSqlCommand("delete albums");
            _dbcontext.Database.ExecuteSqlCommand("delete artists");
            _dbcontext.Database.ExecuteSqlCommand("delete genres");
            var genres = new List<Genre>()
            {
                new Genre() { Name="摇滚",Description="Rock"},
                new Genre() { Name="爵士",Description="Jazz"},
                new Genre() { Name="重金属",Description="Metal"},
                new Genre() { Name="慢摇",Description="downtempo"},
                new Genre() { Name="蓝调",Description="blue"},
                new Genre() { Name="拉丁",Description="Latin"},
                new Genre() { Name="流行",Description="Pop"},
                new Genre() { Name="古典",Description="classical"},
                new Genre() { Name="DJ",Description="DJ"},
                new Genre() { Name="嘻哈",Description="HiHop"},
                new Genre() { Name="臭嗨",Description="Tuhi"},
            };
            foreach (var g in genres)
                _dbcontext.Genres.Add(g);

            var artists = new List<Artist> {
                new Artist() { Name="蔡健雅",Sex=true,Description="蔡健雅（Tanya Chua），1975年1月28日出生于新加坡，祖籍中国江苏省，现定居于台湾。歌手、制作人、创作人。"},
                new Artist() { Name="白小白",Sex=false,Description="白小白，中国内地男演员、歌手。2015年7月，发行专辑《你说这样分手》。2016年8月，发行专辑《舞台》；2016年10月，参演电影《超能废物》。2017年4月，发行专辑《最美情侣》。2018年1月，球球合唱发行歌曲《宠爱吖》。"},
                new Artist() { Name="林玉英",Sex=false,Description="台湾歌手林玉英：中国台湾籍，80年代当红著名女星。绰号：范范、顽皮豹。专辑有《女人心.想厝的人》，《小雨》等。于2018年6月去世"},
                new Artist() { Name="卓依婷",Sex=false,Description="5岁开始登台表演，因听众年龄层次跨越度之广，被命名为大众型歌手。卓依婷以唱台湾歌曲出名，对于台湾流行歌的伴唱带，卓依婷翻唱过600首以上的国语与台语歌。 歌曲风格迥异，以柔情甜歌为主。"},
                new Artist() { Name="林俊杰",Sex=true,Description="林俊杰（JJ Lin），新加坡人，流行歌手、词曲创作者、音乐制作人。2003年发行首张创作专辑《乐行者》 ，2004年凭《江南》一曲成名 。2014年以专辑《因你而在 Stories Untold》夺得第25届台湾金曲奖最佳国语男歌手奖 。"},
                new Artist() { Name="邓丽君",Sex=false,Description="邓丽君，1953年1月29日出生于中国台湾省云林县，祖籍河北省大名县，中国台湾歌唱家、日本昭和时代演歌代表人物之一。1995年5月8日16时许 邓丽君因长期感冒未愈伴随支气管炎引起哮喘发作，由于交通堵塞延误救治时间和使用支气管扩张喷剂过量，致使脑部重度缺氧和心脏停顿，于泰国清迈兰姆医院接受近45分钟的全力抢救，17时30分许 邓丽君被证实错失有效救治时机以致抢救无效逝世，终年42岁 ；"},
                new Artist() { Name="刀郎",Sex=true,Description="刀郎，原名罗林。1971年6月22日出生于四川省内江市资中县，歌手、音乐人。"},
                new Artist() { Name="本兮",Sex=false,Description="本兮（1994年6月30日-2016年12月24日），原名马晓晨，出生于新疆奎屯，中国内地原创女歌手，融合RAP和说唱风格，擅长词曲创作。15岁开始于网络发布个人原创作品。 17岁正式踏入歌坛，成立个人音乐品牌“Go！Go！”，并于2011年签约极韵文化。"},
                new Artist() { Name="弦子",Sex=false,Description="弦子（Stringer），原名张弦子。1986年4月22日，出生于广西壮族自治区百色市德保县。毕业于北京现代音乐研修学院，中国流行乐女歌手、演员。"},
                new Artist() { Name="六哲",Sex=true,Description="六哲（Sixzhe），原名李锦，1985年10月18日生于广东雷州，华语流行男歌手、词曲创作人、音乐制作人，毕业于星海音乐学院。2010年6月21日，推出首张专辑《被伤过的心还可以爱谁》正式踏入乐坛。2011年6月21日，推出第二张专辑《我在乎的是你》。2013年7月21，推出第三张专辑《不知道为什么》。2014年，六哲在保持原有的流行音乐领域外，还涉足到影视音乐创作及编剧创作当中，投身影视行业发展。"},
                new Artist() { Name="G.E.M. 邓紫棋",Sex=false,Description="邓紫棋（Gloria Tang Tsz-Kei），又名G.E.M.，原名邓诗颖，1991年8月16日生于中国上海，4岁移居香港，中国香港创作型女歌手。"},
                new Artist() { Name="许嵩",Sex=true,Description="许嵩（Vae），1986年5月14日生于安徽省合肥市，中国内地创作型男歌手，毕业于安徽医科大学。"},
                new Artist() { Name="张杰",Sex=true,Description="张杰，1982年12月20日出生于四川成都，毕业于四川师范大学，内地流行男歌手，行星文化（音乐厂牌）创始人。"},
                new Artist() { Name="孙燕姿",Sex=false,Description="孙燕姿（Stefanie Sun），新加坡人，华语流行女歌手，以独特的嗓音和唱腔、扎实的音乐功底著称。她的歌积极向上、给人力量，个人风格明显，深受听众喜爱。"},
                new Artist() { Name="后弦",Sex=true,Description="后弦（Hoho），1979年12月14日出生于广西柳州，中国内地男歌手，词曲创作人。"},
            };
            foreach (var a in artists)
                _dbcontext.Artists.Add(a);
            _dbcontext.SaveChanges();

            var albums = new List<Album>
            {
                new Album {
                    Title = "谢谢你",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="刀郎"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "永远的战士",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="刀郎"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "若你碰到他",
                    Genre = genres.Single(g=>g.Name =="爵士"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="蔡健雅"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "天使与魔鬼的对话",
                    Genre = genres.Single(g=>g.Name =="慢摇"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="蔡健雅"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "不为谁而作的歌",
                    Genre = genres.Single(g=>g.Name =="臭嗨"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林俊杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "学不会",
                    Genre = genres.Single(g=>g.Name =="臭嗨"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林俊杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "钢琴酒吧 爱你一万年",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林玉英"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "情歌精选-爱拼才会赢",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林玉英"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "闽南语情歌大对唱",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="卓依婷"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "校园青春乐",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="卓依婷"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "蜕变2 少女的心情故事",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="卓依婷"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "蜕变1少女的心情故事",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="卓依婷"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "流行音乐歌",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="本兮"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "情花",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="本兮"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "不爱最大",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="弦子"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "天真",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="弦子"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "风筝",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="孙燕姿"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "完美的一天",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="孙燕姿"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "Xposed",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="G.E.M. 邓紫棋"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "夜空中最亮的性",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="G.E.M. 邓紫棋"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "喜欢你",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="G.E.M. 邓紫棋"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "泡沫",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="G.E.M. 邓紫棋"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "甜蜜蜜",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="邓丽君"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "香港之恋",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="邓丽君"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "在水一方",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="邓丽君"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "我要咖啡",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="邓丽君"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "很有爱",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="后弦"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "古·玩",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="后弦"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "我知道你也很想念",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="后弦"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "你还欠我一个拥抱",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="后弦"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "Vae新歌+精选珍藏合辑",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="许嵩"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "素颜",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="许嵩"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "自定义",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="许嵩"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "寻雾启示",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="许嵩"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "One Chance新歌+精选&2011这就是爱",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="张杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "这就是爱",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="张杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "只要频繁",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="张杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "着魔",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="张杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                   new Album {
                    Title = "款款柔情1",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="卓依婷"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "款款柔情2",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="卓依婷"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "你在看孤独的风景",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="本兮"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "曾经的歌系列",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="本兮"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "Run Away",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="本兮"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "被伤过的心还可以爱谁",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="六哲"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "我在乎的是你",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="六哲"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "累了走了散了",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="六哲"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "JJ陆",
                    Genre = genres.Single(g=>g.Name =="摇滚"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林俊杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "编号89757",
                    Genre = genres.Single(g=>g.Name =="流行"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林俊杰"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                  new Album {
                    Title = "钢琴酒吧 水长流",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林玉英"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
                 new Album {
                    Title = "钢琴酒吧 为何你爱着别人",
                    Genre = genres.Single(g=>g.Name =="古典"),
                    Price = 8.99M,
                    Artist=artists.Single(a=>a.Name=="林玉英"),
                    AlbumArtUrl="/Content/Images/placeholder.gif"},
            };

            /*ForEach(n => _dbcontext.Albums.Add(n));*/
            foreach (var c in albums)
                _dbcontext.Albums.Add(c);
            _dbcontext.SaveChanges();
        }

        //给Genreld和Artistld赋值
        public static void Extend()
        {
            var albums = _dbcontext.Albums.ToList();
            foreach (var album in albums)
            {
                var item = _dbcontext.Albums.Find(album.ID);
                item.GenreId = item.Genre.ID.ToString();
                item.Artistld = item.Artist.ID.ToString();
                _dbcontext.SaveChanges();
                Thread.Sleep(3);
            }
        }
    }
}