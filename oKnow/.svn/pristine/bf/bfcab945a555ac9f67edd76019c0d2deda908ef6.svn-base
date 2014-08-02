using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;

namespace OKnow.Questions
{
    public class MusicQuestions
    {
        private static Song thisWillBe;
        private static Song glasgowKiss;
        private static Song kotovsyndrome;
        private static Song clintEastwood;
        private static Song semicolon;
        private static Song beastHarlot;

        private static Texture2D linkinParkImage;
        private static Texture2D systemofadown;
        private static Texture2D systematicChaos;
        private static Texture2D kazoo;
        private static Texture2D larsUlrich;
        private static Texture2D sitar;

        public static void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            thisWillBe = Content.Load<Song>("Sounds/thiswillbetheday");
            glasgowKiss = Content.Load<Song>("Sounds/glasgowkiss");
            kotovsyndrome = Content.Load<Song>("Sounds/kotovsyndrome");
            clintEastwood = Content.Load<Song>("Sounds/clintEastwood");
            semicolon = Content.Load<Song>("Sounds/semicolon");
            beastHarlot = Content.Load<Song>("Sounds/beast_harlot");

            linkinParkImage = Content.Load<Texture2D>("Images/linkinparklivingthings");
            systemofadown = Content.Load<Texture2D>("Images/systemofadown");
            systematicChaos = Content.Load<Texture2D>("Images/systematicchaos");
            kazoo = Content.Load<Texture2D>("Images/kazoo");
            larsUlrich = Content.Load<Texture2D>("Images/larsUlrich");
            sitar = Content.Load<Texture2D>("Images/sitar");
        }

        public static void addQuestions(QuestionPool pool)
        {
            String[] choices;
            Question question;

            choices = new string[] { "Alligator", "Boxer", "High Violet", "The National" };
            pool.addQuestion(Category.MUSIC, "Which album by The National was released in 2005?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "This Is a Long Drive for Someone with Nothing to Think About", "The Lonesome Crowded West", "The Moon & Antarctica", "Good News for People Who Love Bad News" };
            pool.addQuestion(Category.MUSIC, "What was the first Album Released by Modest Mouse?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Philadelphia, PA", "Austin, TX", "Portland, OR", "Seattle, WA" };
            pool.addQuestion(Category.MUSIC, "Which city is the band MewithOutYou from?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Whiskeytown", "Wilco", "The Cardinals", "The Finger" };
            pool.addQuestion(Category.MUSIC, "Prior to beginning his solo career, Ryan Adams was a member of which band?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Ten Stories", "It's All Crazy! It's All False! It's All a Dream! It's Alright", "Brother, Sister", "Catch for Us the Foxes" };
            pool.addQuestion(Category.MUSIC, "WewithoutYou released the track 'Fox's Dream of the Log Flume' on which album?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Sub Pop", "Secretly Canadian", "PAX AM", "Expunged Records" };
            pool.addQuestion(Category.MUSIC, "Which record label did Damien Jurado release \"I Break Chairs\"?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Half Moon", "Oviedo", "One Red Thread", "The Bitter End" };
            pool.addQuestion(Category.MUSIC, "Which Blind Pilot track was featured on the album 'We are the Tide'", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Born in the USA", "Hungry Heart", "The River", "Point Blank" };
            pool.addQuestion(Category.MUSIC, "Which track was not a single on Bruce Springsteen’s album 'The River'?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Jeff Tweedy", "Win Butler", "Jeremy Gara", "Regine Chassagne" };
            pool.addQuestion(Category.MUSIC, "Which individual was never a member of Arcade Fire?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "2006", "2005", "2007", "2004" };
            pool.addQuestion(Category.MUSIC, "What year did The Killers release the album 'Sam's Town'?", choices, Answer.ONE, QuestionType.STANDARD);

            /**
             * Added by Bryan Choi
             */
            choices = new string[] { "Johnny Cash", "Frank Sinatra", "Elvis Presley", "James Dean" };
            pool.addQuestion(Category.MUSIC, "What music legend is respectfully referred to as \"The King\"?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Book of Mormon", "Mormon Times", "The Tale of Joseph Smith", "The Story of Mormon" };
            pool.addQuestion(Category.MUSIC, "A recent production from South Park creators Trey Parker and Matt Stone, what musical tells the story of two young Mormon boys who are sent to Uganda in an effort try to share their faith?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Dropstep", "Fusion Jazz", "Wubdrop", "Dubstep" };
            pool.addQuestion(Category.MUSIC, "A fairly recent genre of music, what style features wobble bass, generally known as a \"wub\", and a brief moment of silence before increasing in intensity, also known as a \"drop\"?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Ke$ha", "Adele", "Taylor Swift", "Lorde" };
            pool.addQuestion(Category.MUSIC, "What famous singer has trouble hanging on to her man and is known for such singles as \"Red\", \"White Horse\", and \"22\"?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Tauheed \"2 Chainz\" Epps", "Marchall \"Eminem\" Mathers", "Mick Jagger", "Justin Bieber" };
            pool.addQuestion(Category.MUSIC, "What popular \"bad boy\" of music was recently involved in a DUI that sparked a petition to deport him back to his home country of Canada?", choices, Answer.FOUR, QuestionType.STANDARD);
            
            choices = new string[] { "All Star", "Stairway to Heaven", "Back in Black", "Beat It" };
            pool.addQuestion(Category.MUSIC, "What song, released in 1971, a classic starting point among beginning guitarists, makes reference to \"a lady who’s sure all that glitters is gold\"?", choices, Answer.TWO, QuestionType.STANDARD);
            
            choices = new string[] { "Piccolo", "Cello", "Erhu", "Harp" };
            pool.addQuestion(Category.MUSIC, "What bowed stringed instrument, commonly found in orchestral and chamber music, has f-holes on its body and is roughly between a violin and bass in size?", choices, Answer.TWO, QuestionType.STANDARD);
            
            choices = new string[] { "White Snake", "Metallica", "AC/DC", "Black Sabbath" };
            pool.addQuestion(Category.MUSIC, "What Australian rock band was \"Thunderstruck\" to find that by 2010, they had sold more than 200 million albums worldwide?", choices, Answer.THREE, QuestionType.STANDARD);
            
            choices = new string[] { "Ride of the Valkyries", "Flight of Walkure", "Eine Kleine Nachtmusik", "Moonlight Sonata" };
            pool.addQuestion(Category.MUSIC, "What piece signifies the beginning of Act III of Wagner's \"Die Walkure\", also seen in the film Apocalypse Now and even in a small Buggs Bunny short, featuring him as a fair maiden in golden armor who must run from Elmer Fudd?", choices, Answer.ONE, QuestionType.STANDARD);
            
            choices = new string[] { "Flowers Bloom", "Season's Warmth", "Magic Flue", "Four Seasons" };
            pool.addQuestion(Category.MUSIC, "What music suite, composed by Antonio Vivaldi, features such pieces as \"Spring\" and \"Summer\"?", choices, Answer.FOUR, QuestionType.STANDARD);

                // Image Questions
            choices = new string[] { "Vuvuzela", "Sitar", "Kazoo", "Glockenspiel" };
            question = new Question(Category.MUSIC, "What is this annoying plastic instrument called?", choices, Answer.THREE, QuestionType.IMAGE);
            question.Image = kazoo;
            pool.addImageQuestion(question);

            choices = new string[] { "Metallica", "Avenged Sevenfold", "Iron Maiden", "Black Sabbath" };
            question = new Question(Category.MUSIC, "Also seen briefly in the movie \"Get Him to the Greek\", this man is the drummer for what band?", choices, Answer.ONE, QuestionType.IMAGE);
            question.Image = larsUlrich;
            pool.addImageQuestion(question);

            choices = new string[] { "Spanish Guitar", "Sitar", "Melodica", "Classical Guitar" };
            question = new Question(Category.MUSIC, "What insturment is the bearded gentleman holding?", choices, Answer.TWO, QuestionType.IMAGE);
            question.Image = sitar;
            pool.addImageQuestion(question);

                // Sound Questions
            choices = new string[] { "Arctic Monkeys", "Flobots", "Avicii", "Gorillaz" };
            question = new Question(Category.MUSIC, "What band sings this song?", choices, Answer.FOUR, QuestionType.MUSIC);
            question.Sound = clintEastwood;
            pool.addMusicQuestion(question);

            choices = new string[] { "Alanis Morissette", "Solange", "Rihanna", "Mariah Carey" };
            question = new Question(Category.MUSIC, "Who is featured in this song by Lonely Island?", choices, Answer.TWO, QuestionType.MUSIC);
            question.Sound = semicolon;
            pool.addMusicQuestion(question);

            choices = new string[] { "Shephard of Fire", "Hail to the King", "Bat City", "Beast and the Harlot" };
            question = new Question(Category.MUSIC, "What is the name of this Avenged Sevenfold song?", choices, Answer.FOUR, QuestionType.MUSIC);
            question.Sound = beastHarlot;
            pool.addMusicQuestion(question);

            /**
             * Vikram's Questions
             */
            choices = new string[] { "2001", "2002", "2003", "None of these" };
            pool.addQuestion(Category.MUSIC, "Male vocalist MC Hammer released a new hit in....?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "2004", "2002", "1999", "2010" };
            pool.addQuestion(Category.MUSIC, "When did Jennifer Lopez and Marc Anthony get married?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Get Back!", "Step Up!", "Get Right!", "Get Right Up!" };
            pool.addQuestion(Category.MUSIC, "Which of the following is a Jennifer Lopez's song?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Snoop Dogg", "Ice Cube", "Eminem", "Nelly" };
            pool.addQuestion(Category.MUSIC, "What male vocalist sings 'Drop It Like It's Hot'?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Nickleback", "Eminem", "50 Cent", "Jay-Z" };
            pool.addQuestion(Category.MUSIC, "What male vocalist sings 'Candy Shop'?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Gavin Degraw", "Bob Dillon", "David Grey", "Elton John" };
            pool.addQuestion(Category.MUSIC, "Which of these artists sang the song 'This Year's Love'", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Miss Understood", "Miss Universe", "Miss Understand", "Miss Independent" };
            pool.addQuestion(Category.MUSIC, "Kelly Clarkson's debut song was:", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "He's Home", "He's Gone", "Nobody's Home", "I'm Gone" };
            pool.addQuestion(Category.MUSIC, "Avril Lavigne sang the song:", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Just Like A Pill", "Family Picture", "Get This Party Started", "None of These" };
            pool.addQuestion(Category.MUSIC, "Which of these is not on Pink's album 'Missundaztood'", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "I would take you with me", "Do you think time will pass me by?", "Do you think time will pass us by?", "Would you catch me if I fall?" };
            pool.addQuestion(Category.MUSIC, "Finish the lyric: 'If I could fall into the sky ...", choices, Answer.TWO, QuestionType.STANDARD);

            //Sound Questions
            choices = new string[] { "This Will Be The Day", "American Pie", "Call on Me", "YMCA" };
            question = new Question(Category.MUSIC, "Name this song.", choices, Answer.ONE, QuestionType.MUSIC);
            question.Sound = thisWillBe;
            pool.addMusicQuestion(question);

            choices = new string[] { "Suspended Animation", "Damage Control", "Glasgow Kiss", "Tunnel Vision" };
            question = new Question(Category.MUSIC, "Name this song.", choices, Answer.THREE, QuestionType.MUSIC);
            question.Sound = glasgowKiss;
            pool.addMusicQuestion(question);

            choices = new string[] { "Endgame", "Appeal to Reason", "Siren Song of the Counter Culture", "The Sufferer and the Witness" };
            question = new Question(Category.MUSIC, "On what Rise Against album does this song appear?", choices, Answer.TWO, QuestionType.MUSIC);
            question.Sound = kotovsyndrome;
            pool.addMusicQuestion(question);

            choices = new string[] { "Hypnotize", "Meteora", "Minutes to Midnight", "Living Things" };
            question = new Question(Category.MUSIC, "What album is this the cover art for?", choices, Answer.FOUR, QuestionType.IMAGE);
            question.Image = linkinParkImage;
            pool.addImageQuestion(question);

            choices = new string[] { "Mesmerize", "Hypnotize", "System of a Down", "Steal this Album!" };
            question = new Question(Category.MUSIC, "What album is this the cover art for?", choices, Answer.THREE, QuestionType.IMAGE);
            question.Image = systemofadown;
            pool.addImageQuestion(question);

            choices = new string[] { "Suspended Animation", "Systematic Chaos", "Octavarium", "Awake" };
            question = new Question(Category.MUSIC, "What album is this the cover art for?", choices, Answer.TWO, QuestionType.IMAGE);
            question.Image = systematicChaos;
            pool.addImageQuestion(question);
        }
    }
}
