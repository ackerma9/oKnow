﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;

namespace OKnow.Questions
{
    public class TVShowQuestions
    {
        private static Song communityIntroSong;
        private static Texture2D gameofThronesImage;

        public static void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            communityIntroSong = Content.Load<Song>("Sounds/communityintro");
            gameofThronesImage = Content.Load<Texture2D>("Images/gameofthrones");

        }

        public static void addQuestions(QuestionPool pool)
        {
            String[] choices;

            choices = new string[] { "Bob Sagaet", "Jason Segel", "Josh Radnor", "Neil Patrick Harris" };
            pool.addQuestion(Category.TVSHOWS, "Who plays the role of Ted Mosby in How I Met Your Mother?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "The Vampire Diaries", "True Blood", "The Walking Dead", "Supernatural" };
            pool.addQuestion(Category.TVSHOWS, "Which TV Show premiered in 2009 and is based on a novel series penned by L.J. Smith?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Nikita", "Birds of Prey", "Arrow", "Smallville" };
            pool.addQuestion(Category.TVSHOWS, "What TV series follows billionaire playboy Oliver Queen as he fights crime and depravity as a secret vigilante", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Sons of Anarchy", "The Walking Dead", "Heroes", "American Horror Story" };
            pool.addQuestion(Category.TVSHOWS, "What TV show set a record for most views of a drama series episode with its season four premiere?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "The Tudors", "Downton Abbey", "Boardwalk Empire", "Lark Rise to Candleford" };
            pool.addQuestion(Category.TVSHOWS, "Which British period drama portrays the lives of the upper-class Crawley family and their servants in the post-Edwardian era?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Nip/Tuck", "The Americans", "Modern Family", "American Horror Story" };
            pool.addQuestion(Category.TVSHOWS, "The duo of Ryan Murphy and Brad Falchukand created Glee and what other TV show?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Mohinder", "Noah", "Hiro", "Peter" };
            pool.addQuestion(Category.TVSHOWS, "On the TV show Heroes, whose special ability is time travel?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Gossip Girl", "One Tree Hill", "Veronica Mars", "Privileged" };
            pool.addQuestion(Category.TVSHOWS, "Narrated by Kristen Bell, what American teen drama features privileged teenagers living on the Upper Eastside of New York City?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Mad Men", "Downton Abbey", "Homeland", "Breaking Bad" };
            pool.addQuestion(Category.TVSHOWS, "Which TV show won the 2013 Emmy for best drama?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "New Orleans", "Miami", "Baton Rouge", "Houston" };
            pool.addQuestion(Category.TVSHOWS, "Where does Dexter live in the TV show Dexter?", choices, Answer.TWO, QuestionType.STANDARD);

            /**
             * Brian's Questions
             */
            choices = new string[] { "Odin", "Isis", "FBI", "MI6" };
            pool.addQuestion(Category.TVSHOWS, "Sterling Archer works for which dubious International Spy Agency?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "How I Met Your Mother", "2 and a Half Men", "Modern Family", "Eastbound and Down" };
            pool.addQuestion(Category.TVSHOWS, "Neal Patrick Harris is the co-star of which acclaimed sitcom?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Jessie", "Black Mamba", "Heisenberg", "Blue" };
            pool.addQuestion(Category.TVSHOWS, "What is Walter White’s Pseudo name in the television show Breaking Bad?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Los Angeles", "Inglewood", "Rancho Cucamonga", "San Diego" };
            pool.addQuestion(Category.TVSHOWS, "What California city does Comedy Central's Workaholics take place in?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "South Park", "The Simpsons", "Law and Order", "Family Guy" };
            pool.addQuestion(Category.TVSHOWS, "What is the longest running Television show of all time?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "ShowTime", "Cinemax", "Starz", "HBO" };
            pool.addQuestion(Category.TVSHOWS, "The Game of Thrones T.V. series is owned by which premium television service?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "FX", "AMC", "TBS", "ABC" };
            pool.addQuestion(Category.TVSHOWS, "The Walking Dead is owned by which cable television channel?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Conan O'Brien", "Jay Leno", "David Letterman", "Jimmy Fallon" };
            pool.addQuestion(Category.TVSHOWS, "Who is the current host of the Tonight Show on NBC?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Kenny", "Kyle", "Jimmy", "Cartman" };
            pool.addQuestion(Category.TVSHOWS, "Which of the following is not a main character of South Park?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "CBS", "NBC", "ESPN", "TNT" };
            pool.addQuestion(Category.TVSHOWS, "Which TV station  has the sole rights to publish the 2014 Winter Olympics?", choices, Answer.TWO, QuestionType.STANDARD);

            /**
             * Danny's Questions
             */
            choices = new string[] { "George Costanza", "Jerry Seinfeld", "Cosmo Kramer", "Newman" };
            pool.addQuestion(Category.TVSHOWS, "What Seinfeld charcter takes off his shirt during visits to the toilet?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "The Bridal Balloon", "A tire on Michael's car", "His scrotum", "An aersol can" };
            pool.addQuestion(Category.TVSHOWS, "The night before Pam and Jim's wedding in Niagara Falls, what did Andy accidently puncture?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Pam", "Michael", "Creed", "Phyllis" };
            pool.addQuestion(Category.TVSHOWS, "Who was the only character to successully run barefoot across hot coals in \"Beach Games,\" a third season episode where Michael takes the office gang to Lake Scranton?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Selling real estate without a license", "Impersonating a police officer", "Retracted his marriage proposal to Kelly, and her parents pressed charges", "Double-posting sales" };
            pool.addQuestion(Category.TVSHOWS, "The Office's Ryan Howard was arrested and imprisoned. What crime did he commit?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "60", "55", "52", "49" };
            pool.addQuestion(Category.TVSHOWS, "How old is Walter White in the season 5 premiere of Breaking Bad?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Mike's Granddaughter and the parents of Drew", "Saul and Walt", "April and her son", "Badger and Skinny" };
            pool.addQuestion(Category.TVSHOWS, "In Breaking Bad's \"Blood Money,\" Jesse wanted to give his money to which two people?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Hank", "Skylar", "Marie", "Saul" };
            pool.addQuestion(Category.TVSHOWS, "In episode 12 of season 5 of Breaking Bad, who has been researching about untraceable posions?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Tyrion", "Varys", "Grenn", "Cersei" };
            pool.addQuestion(Category.TVSHOWS, "In Game of Thrones, who said: Prodigies appear in the oddest of places", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Castelry Rock", "Winterfell", "King's Landing", "Highgarden" };
            pool.addQuestion(Category.TVSHOWS, "In the show Game of Thrones, what is the capital city of Westeros?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Rodrick", "Shae", "Bronn", "Podrick" };
            pool.addQuestion(Category.TVSHOWS, "Who dresses Tyrion in armour for the battle at Blackwater Bay?", choices, Answer.FOUR, QuestionType.STANDARD);

            //Sound Questions
            choices = new string[] { "Friends", "Scrubs", "Community", "Modern Family" };
            Question question = new Question(Category.TVSHOWS, "For which show's intro is this song played?", choices, Answer.THREE, QuestionType.MUSIC);
            question.Sound = communityIntroSong;
            pool.addMusicQuestion(question);

            choices = new string[] { "Game of Thrones", "The Tudors", "Grimm", "Supernatural" };
            question = new Question(Category.TVSHOWS, "What TV show is this image from?", choices, Answer.ONE, QuestionType.IMAGE);
            question.Image = gameofThronesImage;
            pool.addImageQuestion(question);
        }
    }
}
