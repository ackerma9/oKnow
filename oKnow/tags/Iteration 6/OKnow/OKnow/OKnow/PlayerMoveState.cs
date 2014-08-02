using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OKnow.StaticContent;
using OKnow.Questions;
using OKnow.Pieces;
using Microsoft.Xna.Framework.Media;

namespace OKnow
{
    public class PlayerMoveState : NoOpGameState
    {
        protected AbstractTile questionTile = null;

        public override void TileClick(AbstractTile tile)
        {
            AbstractTile playerTile = Game1.GameSingleton.GameBoard.CurrentPlayer.getTile();
            Question question;

            if (playerTile.IsAdjacent(tile) &&
                Game.CurrentScreen == Screen.BOARD)
            {
                if (tile.GetType() != typeof(EndTile) &&
                    tile.GetType() != typeof(StartTile))
                {
                    questionTile = tile;
                    if (questionTile.GetType() == typeof(MusicTile))
                    {
                        question = BoardGenerator.pool.getRandomMusicQuestion(Game.GameBoard.Category);
                    }
                    else if (questionTile.GetType() == typeof(ImageTile))
                    {
                        question = BoardGenerator.pool.getRandomImageQuestion(Game.GameBoard.Category);
                    }
                    else
                    {
                        question = BoardGenerator.pool.getRandQuestion(Game.GameBoard.Category);
                    }

                    if (question.GetQuestionType() == QuestionType.MUSIC)
                    {
                        question.PlaySound();
                    }

                    Game.ShowQuestion(question, questionTile);

                }
                else if (tile.GetType() == typeof(EndTile))
                {
                    Game1.GameSingleton.EndGame();
                }
            }
        }

        public override void QuestionAnswered(bool isCorrect, Question question)
        {
            if (questionTile == null)
            {
                throw new Exception("No question yet");
            }

            MediaPlayer.Stop();
            Player currentPlayer = Game.GameBoard.CurrentPlayer;

            if (isCorrect)
            {
                //question is correct
                currentPlayer.totalScore += question.getPoints(currentPlayer.attempt);
                currentPlayer.attempt = 1;

                currentPlayer.setTile(questionTile);

            }
            else
            {
                //question is incorrect
                currentPlayer.attempt += 1;

                if (questionTile.GetType() == typeof(DeathTile))
                {
                    currentPlayer.setTile(BoardGenerator.StartTile);
                }
            }

            questionTile = null;
            Game.ShowBoard();
            Game.GameBoard.NextTurn();
        }

        public override void Activate()
        {
            Game.ShowBoard();
        }

        public override String Name
        {
            get { return "Normal"; }
        }

        public override void UsePowerUp()
        {
            IGameState powerUpTemp = Game.GameBoard.CurrentPlayer.ConsumePowerUp();
            if (powerUpTemp != null)
            {
                Game.GameState = powerUpTemp;
            }
        }
    }
}
