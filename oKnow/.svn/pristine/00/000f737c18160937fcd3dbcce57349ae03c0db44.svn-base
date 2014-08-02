using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.StaticContent;
using OKnow.Pieces;

namespace OKnow
{
    public class Player
    {
        public int totalScore;
        public int attempt;
        private String name;
        private AbstractTile currentTile;
        private int playerID;
        private IGameState powerUp = null;

        private static int nextPlayerID = 0;
        private static Color[] playerColors = new Color[] { Color.Red, Color.MediumVioletRed, Color.Green, Color.MidnightBlue };
        private static Vector2[] playerPieceOffset = new Vector2[] { new Vector2(0, 0),
                                                                    new Vector2(AbstractTile.tileLength / 2, 0), 
                                                                    new Vector2(0, AbstractTile.tileLength / 2),
                                                                    new Vector2(AbstractTile.tileLength / 2, AbstractTile.tileLength / 2)};

        public static void Reset()
        {
            nextPlayerID = 0;
        }

        public static int MaxPlayers
        {
            get { return GameBoard.maxPlayers; }
        }

        public Vector2 PlayerPieceOffset
        {
            get { return playerPieceOffset[playerID]; }
        }

        public Color Color
        {
            get { return playerColors[playerID]; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public Player(AbstractTile tile) : this("Player" + (nextPlayerID + 1), tile) { }

        public Player(String name, AbstractTile tile)
        {
            if (nextPlayerID >= MaxPlayers)
            {
                throw new Exception("More then 4 players have been created.");
            }
            playerID = nextPlayerID;
            this.name = name;
            currentTile = tile;
            this.attempt = 1;
            this.totalScore = 0;
            nextPlayerID++;
        }

        public void setTile(AbstractTile tile)
        {
            IGameState powerUpTemp = tile.GetPowerUp();
            if (powerUpTemp != null)
            {
                this.powerUp = powerUpTemp;
            }
            currentTile = tile;
        }

        public AbstractTile getTile()
        {
            return currentTile;
        }

        public void draw(SpriteBatch spriteBatch)
        {
            Rectangle outline = currentTile.Outline;

            spriteBatch.Draw(StaticTextures.Pixel, new Rectangle(outline.X + (int)(PlayerPieceOffset.X), outline.Y + (int)(PlayerPieceOffset.Y), outline.Width / 2, outline.Height / 2), Color);
        }

        public void drawStats(SpriteBatch spriteBatch)
        {
            String turnText = "Current Turn: ";
            String attemptText = "Current Attempt: " + attempt;
            String scoreText = "Total Score: " + totalScore;
            String powerUp = "PowerUp: " + PowerUpName;

            Vector2 turnTextSize = StaticFonts.PericlesFont18.MeasureString(turnText);

            spriteBatch.DrawString(StaticFonts.PericlesFont18, turnText, new Vector2(0), Color.Orange);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, name, new Vector2((int)turnTextSize.X, 0), Color);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, attemptText, new Vector2(0, (int)turnTextSize.Y), Color.Orange);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, scoreText, new Vector2(0, (int)turnTextSize.Y * 2), Color.Orange);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, powerUp, new Vector2(0, (int)turnTextSize.Y * 3), Color.Orange);
        }

        public void drawScore(SpriteBatch spriteBatch, int i, int offset)
        {
            String playerScoreText = ": " + totalScore;
            Vector2 playerNameSize = StaticFonts.PericlesFont18.MeasureString(Name);

            Vector2 nameLoc = new Vector2(offset, playerNameSize.Y * i);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, Name, nameLoc, Color);
            Vector2 scoreLoc = new Vector2(offset + (int)playerNameSize.X, (int)nameLoc.Y);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, playerScoreText, scoreLoc, Color.Orange);
        }

        public String PowerUpName
        {
            get
            {
                if (this.powerUp == null)
                {
                    return "No PowerUp";
                }
                else
                {
                    return this.powerUp.Name;
                }
            }
        }

        public IGameState ConsumePowerUp()
        {
            IGameState powerUpTemp = this.powerUp;
            this.powerUp = null;
            return powerUpTemp;
        }
    }
}
