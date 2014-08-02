using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;

namespace OKnow.Questions
{
    /// <summary>
    /// Contains the tv show questions in the game
    /// </summary>
    public class TVShowQuestions
    {
        private static Song communityIntroSong;
        private static Song lawOrderThemeSong;
        private static Song dexterIntroSong;
        private static Texture2D gameofThronesImage;
        private static Texture2D trueDetectiveImage;
        private static Texture2D castleImage;

        /// <summary>
        /// Loads any needed music or image files
        /// </summary>
        public static void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            try
            {
                communityIntroSong = Content.Load<Song>("Sounds/communityintro");
                gameofThronesImage = Content.Load<Texture2D>("Images/gameofthrones");
                dexterIntroSong = Content.Load<Song>("Sounds/dexterIntroSong");
                lawOrderThemeSong = Content.Load<Song>("Sounds/lawOrderSong");
                trueDetectiveImage = Content.Load<Texture2D>("Images/trueDetectiveImage");
                castleImage = Content.Load<Texture2D>("Images/castle");
            }
            catch
            {
            }
        }

        /// <summary>
        /// Adds these questions to the question pool
        /// </summary>
        /// <param name="pool"> the question pool </param>
        public static void AddQuestions(QuestionPool pool)
        {
            String[] choices;

            choices = new string[] { "Bob Sagaet", "Jason Segel", "Josh Radnor", "Neil Patrick Harris" };
            pool.AddQuestion(Category.TVSHOWS, "Who plays the role of Ted Mosby in How I Met Your Mother?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "The Vampire Diaries", "True Blood", "The Walking Dead", "Supernatural" };
            pool.AddQuestion(Category.TVSHOWS, "Which TV Show premiered in 2009 and is based on a novel series penned by L.J. Smith?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Nikita", "Birds of Prey", "Arrow", "Smallville" };
            pool.AddQuestion(Category.TVSHOWS, "What TV series follows billionaire playboy Oliver Queen as he fights crime and depravity as a secret vigilante", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Sons of Anarchy", "The Walking Dead", "Heroes", "American Horror Story" };
            pool.AddQuestion(Category.TVSHOWS, "What TV show set a record for most views of a drama series episode with its season four premiere?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "The Tudors", "Downton Abbey", "Boardwalk Empire", "Lark Rise to Candleford" };
            pool.AddQuestion(Category.TVSHOWS, "Which British period drama portrays the lives of the upper-class Crawley family and their servants in the post-Edwardian era?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Nip/Tuck", "The Americans", "Modern Family", "American Horror Story" };
            pool.AddQuestion(Category.TVSHOWS, "The duo of Ryan Murphy and Brad Falchukand created Glee and what other TV show?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Mohinder", "Noah", "Hiro", "Peter" };
            pool.AddQuestion(Category.TVSHOWS, "On the TV show Heroes, whose special ability is time travel?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Gossip Girl", "One Tree Hill", "Veronica Mars", "Privileged" };
            pool.AddQuestion(Category.TVSHOWS, "Narrated by Kristen Bell, what American teen drama features privileged teenagers living on the Upper Eastside of New York City?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Mad Men", "Downton Abbey", "Homeland", "Breaking Bad" };
            pool.AddQuestion(Category.TVSHOWS, "Which TV show won the 2013 Emmy for best drama?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "New Orleans", "Miami", "Baton Rouge", "Houston" };
            pool.AddQuestion(Category.TVSHOWS, "Where does Dexter live in the TV show Dexter?", choices, Answer.TWO, QuestionType.STANDARD);

            /**
             * Brian's Questions
             */
            choices = new string[] { "Odin", "Isis", "FBI", "MI6" };
            pool.AddQuestion(Category.TVSHOWS, "Sterling Archer works for which dubious International Spy Agency?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "How I Met Your Mother", "2 and a Half Men", "Modern Family", "Eastbound and Down" };
            pool.AddQuestion(Category.TVSHOWS, "Neal Patrick Harris is the co-star of which acclaimed sitcom?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Jessie", "Black Mamba", "Heisenberg", "Blue" };
            pool.AddQuestion(Category.TVSHOWS, "What is Walter White’s Pseudo name in the television show Breaking Bad?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Los Angeles", "Inglewood", "Rancho Cucamonga", "San Diego" };
            pool.AddQuestion(Category.TVSHOWS, "What California city does Comedy Central's Workaholics take place in?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "South Park", "The Simpsons", "Law and Order", "Family Guy" };
            pool.AddQuestion(Category.TVSHOWS, "What is the longest running Television show of all time?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "ShowTime", "Cinemax", "Starz", "HBO" };
            pool.AddQuestion(Category.TVSHOWS, "The Game of Thrones T.V. series is owned by which premium television service?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "FX", "AMC", "TBS", "ABC" };
            pool.AddQuestion(Category.TVSHOWS, "The Walking Dead is owned by which cable television channel?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Conan O'Brien", "Jay Leno", "David Letterman", "Jimmy Fallon" };
            pool.AddQuestion(Category.TVSHOWS, "Who is the current host of the Tonight Show on NBC?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Kenny", "Kyle", "Jimmy", "Cartman" };
            pool.AddQuestion(Category.TVSHOWS, "Which of the following is not a main character of South Park?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "CBS", "NBC", "ESPN", "TNT" };
            pool.AddQuestion(Category.TVSHOWS, "Which TV station  has the sole rights to publish the 2014 Winter Olympics?", choices, Answer.TWO, QuestionType.STANDARD);

            /**
             * Danny's Questions
             */
            choices = new string[] { "George Costanza", "Jerry Seinfeld", "Cosmo Kramer", "Newman" };
            pool.AddQuestion(Category.TVSHOWS, "What Seinfeld charcter takes off his shirt during visits to the toilet?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "The Bridal Balloon", "A tire on Michael's car", "His scrotum", "An aersol can" };
            pool.AddQuestion(Category.TVSHOWS, "The night before Pam and Jim's wedding in Niagara Falls, what did Andy accidently puncture?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Pam", "Michael", "Creed", "Phyllis" };
            pool.AddQuestion(Category.TVSHOWS, "Who was the only character to successully run barefoot across hot coals in \"Beach Games,\" a third season episode where Michael takes the office gang to Lake Scranton?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Selling real estate without a license", "Impersonating a police officer", "Retracted his marriage proposal to Kelly, and her parents pressed charges", "Double-posting sales" };
            pool.AddQuestion(Category.TVSHOWS, "The Office's Ryan Howard was arrested and imprisoned. What crime did he commit?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "60", "55", "52", "49" };
            pool.AddQuestion(Category.TVSHOWS, "How old is Walter White in the season 5 premiere of Breaking Bad?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Mike's Granddaughter and the parents of Drew", "Saul and Walt", "April and her son", "Badger and Skinny" };
            pool.AddQuestion(Category.TVSHOWS, "In Breaking Bad's \"Blood Money,\" Jesse wanted to give his money to which two people?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Hank", "Skylar", "Marie", "Saul" };
            pool.AddQuestion(Category.TVSHOWS, "In episode 12 of season 5 of Breaking Bad, who has been researching about untraceable posions?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Tyrion", "Varys", "Grenn", "Cersei" };
            pool.AddQuestion(Category.TVSHOWS, "In Game of Thrones, who said: Prodigies appear in the oddest of places", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Castelry Rock", "Winterfell", "King's Landing", "Highgarden" };
            pool.AddQuestion(Category.TVSHOWS, "In the show Game of Thrones, what is the capital city of Westeros?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Rodrick", "Shae", "Bronn", "Podrick" };
            pool.AddQuestion(Category.TVSHOWS, "Who dresses Tyrion in armour for the battle at Blackwater Bay?", choices, Answer.FOUR, QuestionType.STANDARD);

            //Sound Questions
            choices = new string[] { "Friends", "Scrubs", "Community", "Modern Family" };
            Question question = new Question(Category.TVSHOWS, "For which show's intro is this song played?", choices, Answer.THREE, QuestionType.MUSIC);
            question.Sound = communityIntroSong;
            pool.AddMusicQuestion(question);

            choices = new string[] { "Dexter", "The Cannibal", "Grimm", "Supernatural" };
            question = new Question(Category.TVSHOWS, "For which show's intro is this song played?", choices, Answer.ONE, QuestionType.MUSIC);
            question.Sound = dexterIntroSong;
            pool.AddMusicQuestion(question);

            choices = new string[] { "CSI: Miami", "Psych", "Law and Order", "Castle" };
            question = new Question(Category.TVSHOWS, "For which show's intro is this song played?", choices, Answer.THREE, QuestionType.MUSIC);
            question.Sound = lawOrderThemeSong;
            pool.AddMusicQuestion(question);

            //Image Questions
            choices = new string[] { "Game of Thrones", "The Tudors", "Grimm", "Supernatural" };
            question = new Question(Category.TVSHOWS, "What TV show is this image from?", choices, Answer.ONE, QuestionType.IMAGE);
            question.Image = gameofThronesImage;
            pool.AddImageQuestion(question);

            choices = new string[] { "Mad Men", "True Detective", "Dexter", "True Crime" };
            question = new Question(Category.TVSHOWS, "Matthew McConaughey and Woody Harlsen star in this new hit hbo show?", choices, Answer.TWO, QuestionType.IMAGE);
            question.Image = trueDetectiveImage;
            pool.AddImageQuestion(question);

            choices = new string[] { "Heroes", "True Detective", "Firefly", "Castle" };
            question = new Question(Category.TVSHOWS, "Nathan Fillion and Stana Katic, shown here, star in what tv show?", choices, Answer.FOUR, QuestionType.IMAGE);
            question.Image = castleImage;
            pool.AddImageQuestion(question);
        }
    }
}
