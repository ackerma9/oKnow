using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace OKnow.Questions
{
    public class VideoGameQuestions
    {
        private static Song halo;
        private static Song luigisballad;
        private static Song carryon;
        private static Song frogTheme;
        private static Song saria;
        private static Song bowserTheme;

        private static Texture2D spyro;
        private static Texture2D masterchief;
        private static Texture2D wario;
        private static Texture2D tepig;
        private static Texture2D honedge;
        private static Texture2D mingy;

        public static void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            try
            {
                halo = Content.Load<Song>("Sounds/halo");
                luigisballad = Content.Load<Song>("Sounds/luigisballad");
                carryon = Content.Load<Song>("Sounds/carryon");
                frogTheme = Content.Load<Song>("Sounds/frog_theme");
                saria = Content.Load<Song>("Sounds/sariaSong");
                bowserTheme = Content.Load<Song>("Sounds/bowserTheme");
            }
            catch
            {
            }

            spyro = Content.Load<Texture2D>("Images/spyro");
            masterchief = Content.Load<Texture2D>("Images/masterchief");
            wario = Content.Load<Texture2D>("Images/wario");
            tepig = Content.Load<Texture2D>("Images/tepig");
            honedge = Content.Load<Texture2D>("Images/honedge");
            mingy = Content.Load<Texture2D>("Images/mingy");
        }

        public static void addQuestions(QuestionPool pool)
        {
            String[] choices;
            Question question;

            choices = new string[] { "Naughty Dog", "Sucker Punch Productions", "Insomniac Games", "Rare Ltd" };
            pool.addQuestion(Category.VIDEOGAMES, "What company developed the first 3 Spyro games on Playstation 1?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Clefairy", "Miltank", "Jigglypuff", "Meowth" };
            pool.addQuestion(Category.VIDEOGAMES, "In Pokemon Gold and Silver, what pokemon does the Goldenrod gym design resemble?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Arbiter", "343 Guilty Spark", "Cortana", "Siri" };
            pool.addQuestion(Category.VIDEOGAMES, "In the Halo games, who is Master Chief's AI sidekick?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Khajit", "Argonian", "Breton", "Nord" };
            pool.addQuestion(Category.VIDEOGAMES, "In the Elder Scrolls games, what race can breath underwater?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Forerunners", "Reapers", "Prophets", "Collectors" };
            pool.addQuestion(Category.VIDEOGAMES, "In the Mass Effect trilogy, who are the ancient mechanical beings charged with a cycle of destruction?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Leather", "Iron", "Wood", "Cobblestone" };
            pool.addQuestion(Category.VIDEOGAMES, "In Minecraft, what basic material can you make tools with but not armor?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Jakobs", "Dahl", "Bandit", "Vladof" };
            pool.addQuestion(Category.VIDEOGAMES, "In Borderlands, what manufacturer makes guns with very large magazines?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Luneth", "Vivi", "Quina", "Freya" };
            pool.addQuestion(Category.VIDEOGAMES, "Who is not a character in Final Fantasy IX?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Modern Warfare", "Modern Warfare 2", "Black Ops", "World at War" };
            pool.addQuestion(Category.VIDEOGAMES, "Which Call of Duty game was the first to feature a horde mode?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Chicago", "Los Angeles", "San Francisco", "Las Vegas" };
            pool.addQuestion(Category.VIDEOGAMES, "On what city is GTA V's Los Santos based?", choices, Answer.TWO, QuestionType.STANDARD);

            /**
             * Questions added by Bryan Choi
             */
            choices = new string[] { "Warhammer", "Call of Duty", "Red Faction", "Gears of War" };
            pool.addQuestion(Category.VIDEOGAMES, "What popular franchise, published by Activision, is a first-person shooter that was originally set in World War II, but features even futuristic weaponry in its newer additions, the latest game including a dog as a partner?", choices, Answer.TWO, QuestionType.STANDARD);
            
            choices = new string[] { "Donkey Kong", "Samus Aran", "Red Beard", "Mario" };
            pool.addQuestion(Category.VIDEOGAMES, "What red-clad plumber, also featured with his brother, has been jumping around and collecting coins ever since his conception in the 1980's?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Dirt", "Bayonetta", "Mass Effect", "Borderlands" };
            pool.addQuestion(Category.VIDEOGAMES, "What popular video game series follows the adventures of Commander Shepherd as he or she, depending on what gender you choose, travels through space trying to stop the rise of the Reapers?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Nintendo 3DS", "Sony PSP 3D", "XBox 3D", "Samsung 3DX" };
            pool.addQuestion(Category.VIDEOGAMES, "What recent handheld console allows owners to play their favorite video games in 3D without the use of 3D glasses?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Dance Dance Revolution: Lord of the Dance", "Guitar Hero: God of Rock", "Patapon", "In the Groove: Gods Among Us" };
            pool.addQuestion(Category.VIDEOGAMES, "What rhythm game, published for the PSP, features the player as a deity who commands a small army by beating drums?", choices, Answer.THREE, QuestionType.STANDARD);
            
            choices = new string[] { "Samus Aran", "Catherine", "Tifa Lockheart", "Master Chief" };
            pool.addQuestion(Category.VIDEOGAMES, "What video game character, generally clad in a \"power suit\", was not revealed to be a woman until the end of her first game?", choices, Answer.ONE, QuestionType.STANDARD);
            
            choices = new string[] { "Titanfall", "ICO", "Sly Cooper", "Assassin's Creed" };
            pool.addQuestion(Category.VIDEOGAMES, "What video game series features characters such as Altair, Ezio, Connor, and Edward while they try to fight against their enemies, the Templars?", choices, Answer.FOUR, QuestionType.STANDARD);
            
            choices = new string[] { "War Type", "Group Battle", "Multiplayer Online Battle Arena", "Role Playing Game" };
            pool.addQuestion(Category.VIDEOGAMES, "What type of game, exemplified by League of Legends and DOTA II, usually features players on two different teams, each player controlling a single character?", choices, Answer.THREE, QuestionType.STANDARD);
            
            choices = new string[] { "Frogger", "Brick", "Snake", "Tetris" };
            pool.addQuestion(Category.VIDEOGAMES, "What tile matching puzzle game, originally created by Alexey Pajitnov, features blocky game pieces in the shape of letter such as I, T, or J?", choices, Answer.FOUR, QuestionType.STANDARD);
            
            choices = new string[] { "Counter Strike: Source", "Borderlands", "Rage", "Left 4 Dead" };
            pool.addQuestion(Category.VIDEOGAMES, "What FPS game published by 2K Games allows players to choose one of four gun-toting characters: Mordecai, Roland, Brick, and Lilith?", choices, Answer.TWO, QuestionType.STANDARD);
    
                // Sound Questions
            choices = new string[] { "Legend of Zelda", "Chrono Trigger", "Disgaea", "Breath of Fire" };
            question = new Question(Category.VIDEOGAMES, "In what video game does this song play?", choices, Answer.TWO, QuestionType.MUSIC);
            question.Sound = frogTheme;
            pool.addMusicQuestion(question);

            choices = new string[] { "Zelada", "Link", "Saria", "Navi" };
            question = new Question(Category.VIDEOGAMES, "Who is this song named for?", choices, Answer.THREE, QuestionType.MUSIC);
            question.Sound = saria;
            pool.addMusicQuestion(question);

            choices = new string[] { "Mike Tyson's Super Punch-Out!", "Robocop 3", "Twisted metal", "Super Mario 64" };
            question = new Question(Category.VIDEOGAMES, "What game is this song from?", choices, Answer.FOUR, QuestionType.MUSIC);
            question.Sound = bowserTheme;
            pool.addMusicQuestion(question);

                // Image Questions
            choices = new string[] { "It's Tepig!", "It's Swinub!", "It's Grumpig!", "It's Pignite!" };
            question = new Question(Category.VIDEOGAMES, "Who's that pokemon?", choices, Answer.ONE, QuestionType.IMAGE);
            question.Image = tepig;
            pool.addImageQuestion(question);

            choices = new string[] { "It's Aegislash!", "It's Gible!", "It's Agumon!", "It's Honedge!" };
            question = new Question(Category.VIDEOGAMES, "Who's that pokemon?", choices, Answer.FOUR, QuestionType.IMAGE);
            question.Image = honedge;
            pool.addImageQuestion(question);

            choices = new string[] { "Tookie Wookie", "Shooktie the Shaman", "Mumbo Jumbo", "Mingy Jongo" };
            question = new Question(Category.VIDEOGAMES, "Who is this robot the likeness of?", choices, Answer.THREE, QuestionType.IMAGE);
            question.Image = mingy;
            pool.addImageQuestion(question);

            /**
             * Brian's Questions
             */
            choices = new string[] { "Halo", "Metal Gear Solid", "Assassin's Creed", "Killzone" };
            pool.addQuestion(Category.VIDEOGAMES, "Solid Snake is the protagonist of which console series?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Activision", "2K Games", "EA Games", "Blizzard" };
            pool.addQuestion(Category.VIDEOGAMES, "Battlefield is produced by which Video Game publishing company?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Nintendo", "Microsoft", "Sony", "All of the Above" };
            pool.addQuestion(Category.VIDEOGAMES, "Which console manufacturer(s) owns the right to the Mario Party Franchise?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Fallout", "Warcraft", "Final Fantasy", "The Elder Scrolls" };
            pool.addQuestion(Category.VIDEOGAMES, "Skyrim is apart of the world of which PC series?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Halo", "Killzone", "Bioshock", "Call of Duty" };
            pool.addQuestion(Category.VIDEOGAMES, "Master Chief is the protagonist of which console series?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Playstation", "Xbox", "Wii", "Nintendo 64" };
            pool.addQuestion(Category.VIDEOGAMES, "Which gaming platform makes use of the Kinect motion tracker?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Dreamcast", "Gamecube", "Nintendo 64", "Xbox" };
            pool.addQuestion(Category.VIDEOGAMES, "The original Mario Party came out for what console?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Activision", "Square Enix", "2K Games", "EA Games" };
            pool.addQuestion(Category.VIDEOGAMES, "The Call of Duty Black Ops series is owned by which console publishing company?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "God of War", "Halo", "Warcraft", "Bioshock" };
            pool.addQuestion(Category.VIDEOGAMES, "Kratos is the protagonist of which video game series?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "New York City", "Boston", "Los Angeles", "Washington D.C." };
            pool.addQuestion(Category.VIDEOGAMES, "Which U.S. city does the story of Ubisoft's Fallout 3 take place?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Titanfall", "Halo", "Destiny", "Call of Duty" };
            question = new Question(Category.VIDEOGAMES, "What game does this theme song belong to?", choices, Answer.TWO, QuestionType.MUSIC);
            question.Sound = halo;
            pool.addMusicQuestion(question);

            choices = new string[] { "Mario Theme Song", "A Friendly Character", "Luigi's Ballad", "Peach Soliloquy" };
            question = new Question(Category.VIDEOGAMES, "What is the name of the video game song?", choices, Answer.THREE, QuestionType.MUSIC);
            question.Sound = luigisballad;
            pool.addMusicQuestion(question);

            choices = new string[] { "Ghosts", "Modern Warfare 3", "Black Ops", "Black Ops II" };
            question = new Question(Category.VIDEOGAMES, "In what Call of Duty game does this song appear?", choices, Answer.FOUR, QuestionType.MUSIC);
            question.Sound = carryon;
            pool.addMusicQuestion(question);

            choices = new string[] { "Spyro", "Ratchet", "Banjo", "Bottles" };
            question = new Question(Category.VIDEOGAMES, "Who is this video game character?", choices, Answer.ONE, QuestionType.IMAGE);
            question.Image = spyro;
            pool.addImageQuestion(question);

            choices = new string[] { "Noble 6", "Master Chief", "Carter", "Cortana" };
            question = new Question(Category.VIDEOGAMES, "Who is this video game character?", choices, Answer.TWO, QuestionType.IMAGE);
            question.Image = masterchief;
            pool.addImageQuestion(question);

            choices = new string[] { "Mario", "Luigi", "Wario", "Peach" };
            question = new Question(Category.VIDEOGAMES, "Who is this video game character?", choices, Answer.THREE, QuestionType.IMAGE);
            question.Image = wario;
            pool.addImageQuestion(question);
        }
    }
}
