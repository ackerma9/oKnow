using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Graphics;

namespace OKnow.Questions
{
    public class MovieQuestions
    {
        private static Song getToTheChopper;
        private static Song notATumor;
        private static Song putCookieDown;
        private static Texture2D hangoverImage;
        private static Texture2D emporerImage;
        private static Texture2D bradFightClubImage;
        public static void LoadContent(Microsoft.Xna.Framework.Content.ContentManager Content)
        {
            getToTheChopper = Content.Load<Song>("Sounds/gettothechopper");
            notATumor = Content.Load<Song>("Sounds/ItsNotATumor");
            putCookieDown = Content.Load<Song>("Sounds/putCookieDown");
            hangoverImage = Content.Load<Texture2D>("Images/hangover");
            emporerImage = Content.Load<Texture2D>("Images/emporersNewGrooveImage");
            bradFightClubImage = Content.Load<Texture2D>("Images/bradFightClubImage");
        }

        public static void addQuestions(QuestionPool pool)
        {
            String[] choices;

            choices = new string[] { "Callahan", "Flint", "Harrigan", "Steele" };
            pool.addQuestion(Category.MOVIES, "In the Dirty Harry movies starring Clint Eastwood as Dirty Harry, what was Harry's last name?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "$16 million", "$1 million", "$6 million", "$25 million" };
            pool.addQuestion(Category.MOVIES, "How much of his own money did Francis Ford Coppola put up to finish the movie  'Apocalypse Now' when it ran wildly over budget?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Full Metal Jacket", "Fatal Attraction", "Broadcast News", "Angel Heart" };
            pool.addQuestion(Category.MOVIES, "What  1987 film was based on a novel called The Short Timers by Gustav Hasford?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Humphrey Bogart", "James Cagney", "Clint Eastwood", "Burt Lancaster" };
            pool.addQuestion(Category.MOVIES, "Which of the following actors has the middle name 'DeForest'?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Skull Island", "Monster Island", "Borneo", "Ape Island" };
            pool.addQuestion(Category.MOVIES, "What was the name of the island on which King Kong was discovered in the original 1933 movie?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Donald Duck and Daffy Duck", "Bambi and Bullwinkle", "Garfield and Sylvester", "Speedy Gonzales and Minnie Mouse" };
            pool.addQuestion(Category.MOVIES, "In the movie Who Framed Roger Rabbit, which pair of genetically similar characters perform a piano duet?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "$297,000", "$497,000", "$97,000", "$797,000" };
            pool.addQuestion(Category.MOVIES, "The Moon of Barods, a diamond that Marilyn Monroe wore when singing 'Diamonds Are A Girl's Best Friend' in the film Gentlemen prefer Blondes, was auctioned off at Christies for how much in 1990?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "best actor", "best actress", "best picture", "best supporting actor" };
            pool.addQuestion(Category.MOVIES, "Which one of these Academy Awards did Gone With the Wind not win?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Cary Grant", "W.C. Fields", "James Stewart", "John Wayne" };
            pool.addQuestion(Category.MOVIES, "In the 1933 movie where May West spoke the line 'Come up and see me sometime' , called She Done Him Wrong, who was her co-star?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Dirty Harry", "Magnum Force", "Sudden Impact", "Tightrope" };
            pool.addQuestion(Category.MOVIES, "Clint Eastwood gave us the immortal line, 'Go ahead... make my day', in what film?", choices, Answer.ONE, QuestionType.STANDARD);

            /**
             * Vikram's Questions
             */
            choices = new string[] { "Tom Hanks", "Tom Cruise", "Ben Affleck", "Leonardo DiCaprio" };
            pool.addQuestion(Category.MOVIES, "Which one of these actors starred in the movie 'Blood Diamond'", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Gone With the Wind", "Great Expectations", "Harold and Maude", "The Matrix" };
            pool.addQuestion(Category.MOVIES, "'After all, tomorrow is another day!' was the last line in which Oscar-winning Best Picture?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Al Pacino and Timothy Hutton", "Jack Nicholson and Kevin Spacey", "Laurence Olivier and Roberto Benigni", "Tom Hanks and Paul Newman" };
            pool.addQuestion(Category.MOVIES, "Which two actors directed themselves in movies and won Oscars for Best Actor?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Jack Nicholson", "Laurence Olivier", "Spencer Tracy", "Paul Newman" };
            pool.addQuestion(Category.MOVIES, "Who is the most nominated actor in Academy history?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "Ace in the Hole (1951)", "Double Indemnity (1944)", "The Maltese Falcon (1941)", "Sunset Boulevard (1950)" };
            pool.addQuestion(Category.MOVIES, "Which classic Billy Wilder film noir was the basis for the plot in director Lawrence Kasdan's neo-noir Body Heat (1981), starring Kathleen Turner and William Hurt?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Brokeback Mountain (2005)", "Cimarron (1930/31)", "The Last Wagon (1956)", "Stagecoach (1939)" };
            pool.addQuestion(Category.MOVIES, "What was the first Western to win the Academy Award for Best Picture?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "A Streetcar Named Desire (1951)", "The Color Purple (1985)", "My Man Godfrey (1936)", "The Turning Point (1997)" };
            pool.addQuestion(Category.MOVIES, "What was the first film to receive an Academy Award nomination in each of the performance categories?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Dial M for Murder (1954)", "The Getaway (1972)", "Hoodlum (1997)", "The Usual Suspects (1995)" };
            pool.addQuestion(Category.MOVIES, "In which plot-twisting movie was it revealed in the surprise ending that the crippled con man who was released after being interrogated in a police station was in fact the criminal mastermind Keyser Soze?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Annie Hall (1977)", "Marty (1955)", "Midnight Cowboy (1969)", "Sunrise (1927)" };
            pool.addQuestion(Category.MOVIES, "Which is the shortest movie to win Best Picture?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Bette Davis and Kate Winslet", "Jessica Tandy and Elizabeth Taylor", "Katharine Hepburn and Luise Rainer", "Meryl Streep and Judi Dench" };
            pool.addQuestion(Category.MOVIES, "Who are the only two actresses to win the Best Actress Oscar (Academy Award) two years consecutively?", choices, Answer.THREE, QuestionType.STANDARD);

            /**
             * Danny's Questions
             */
            choices = new string[] { "The inventor died", "He did not want them", "He lost his real hands", "He was born with out hands" };
            pool.addQuestion(Category.MOVIES, "Why in the movie Edward Scissorhands did Edward never get real hands?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "The magic man", "baked alone", "cal the stallion", "Shake N.." };
            pool.addQuestion(Category.MOVIES, "In the movie Talladega Nights: The Ballad of Ricky Bobby, what is Cal's new nickname after dumping Ricky?", choices, Answer.ONE, QuestionType.STANDARD);

            choices = new string[] { "The Day After Tomorrow", "Twister", "Volcano", "An Inconvient Truth" };
            pool.addQuestion(Category.MOVIES, "Which environmental awareness movie features Al Gore?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Date Movie", "Scary movie 2", "Scary movie 3", "Scary movie 4" };
            pool.addQuestion(Category.MOVIES, "In what movie do they spoof the village, war of the worlds, and the grudge?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "A plane", "A man in a bunny suit", "An Asteroid", "A Jet Engine" };
            pool.addQuestion(Category.MOVIES, "In the movie, Donnie Darko, what falls from the sky into Donnie's Bedroom?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Plasma Contamination", "Engine Imbalance", "Sabotage", "It was a wormhole" };
            pool.addQuestion(Category.MOVIES, "What is the cause for sending the Enterprise into a wormhole?", choices, Answer.TWO, QuestionType.STANDARD);

            choices = new string[] { "Mike Myres", "Freddy Kruger", "Jason Vorhees", "Jigsaw" };
            pool.addQuestion(Category.MOVIES, "What is the serial killer's name in the Friday the 13th horror movies?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Cameron Diaz", "Julia Roberts", "Eliza Dushku", "Kristen Dunst" };
            pool.addQuestion(Category.MOVIES, "Who plays Torrance Shipman in Bring it on?", choices, Answer.FOUR, QuestionType.STANDARD);

            choices = new string[] { "Bill Murray", "Dan Aykroyd", "Chevy Chase", "Kevin Nealson" };
            pool.addQuestion(Category.MOVIES, "Which Saturday Night Live veteran starred in Memoirs of an Invisble Man (1992)?", choices, Answer.THREE, QuestionType.STANDARD);

            choices = new string[] { "Reuben Studdard", "Kelly Clarkson", "Kerry Underwood", "Taylor Hicks" };
            pool.addQuestion(Category.MOVIES, "What American Idol winner made a special appearance in Scooby Doo 2?", choices, Answer.FOUR, QuestionType.STANDARD);

            // Sound questions.
            Question question;
            choices = new string[] { "The Expendables", "Commando", "The Terminator", "Predator" };
            question = new Question(Category.MOVIES, "These famous lines are from what movies?", choices, Answer.FOUR, QuestionType.MUSIC);
            question.Sound = getToTheChopper;
            pool.addMusicQuestion(question);

            choices = new string[] { "Kindergarten Cop", "Jingle All The Way", "Red Heat", "Last Action Hero" };
            question = new Question(Category.MOVIES, "What movie is this sound clip from?", choices, Answer.ONE, QuestionType.MUSIC);
            question.Sound = notATumor;
            pool.addMusicQuestion(question);

            choices = new string[] { "Kindergarten Cop", "Jingle All The Way", "Red Heat", "Last Action Hero" };
            question = new Question(Category.MOVIES, "What movie is this sound clip from?", choices, Answer.TWO, QuestionType.MUSIC);
            question.Sound = putCookieDown;
            pool.addMusicQuestion(question);

            //Image Questions
            choices = new string[] { "Old School", "The Hangover", "Knocked Up", "Step Brothers" };
            question = new Question(Category.MOVIES, "What movie is this image from?", choices, Answer.TWO, QuestionType.IMAGE);
            question.Image = hangoverImage;
            pool.addImageQuestion(question);

            choices = new string[] { "Bambi", "The Emporer's New Groove", "Hercules", "Lion King" };
            question = new Question(Category.MOVIES, "What movie is this sad lamma from?", choices, Answer.TWO, QuestionType.IMAGE);
            question.Image = emporerImage;
            pool.addImageQuestion(question);

            choices = new string[] { "Rusty Ryan", "Mickey O'Neil", "David Mills", "Tyler Durden" };
            question = new Question(Category.MOVIES, "What is the name of Brad Pitt's character shown in the image?", choices, Answer.FOUR, QuestionType.IMAGE);
            question.Image = bradFightClubImage;
            pool.addImageQuestion(question);


        }
    }
}
