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
    /// <summary>
    /// Describes a Player in the game
    /// </summary>
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
        /// <summary>
        /// Resets the nextPlayerID
        /// </summary>
        public static void Reset()
        {
            nextPlayerID = 0;
        }

        /// <summary>
        /// Returns the maximum number of players
        /// </summary>
        public static int MaxPlayers
        {
            get { return GameBoard.maxPlayers; }
        }

        /// <summary>
        /// Returns the Player piece offset based on the Player's playerID
        /// </summary>
        public Vector2 PlayerPieceOffset
        {
            get { return playerPieceOffset[playerID]; }
        }

        /// <summary>
        /// Return the color of the Player's piece based on the Player's playerID
        /// </summary>
        public Color Color
        {
            get { return playerColors[playerID]; }
        }

        /// <summary>
        /// Get or Set the Player's name
        /// </summary>
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Constructs a player and puts him on the tile passed in.
        /// </summary>
        /// <param name="tile">The tile the player should be started on</param>
        public Player(AbstractTile tile) : this("Player" + (nextPlayerID + 1), tile) { }
        
        /// <summary>
        /// Auxilliary constructor used to actually construct the Player and put him on the tile.
        /// </summary>
        /// <param name="name">Name to set Player name to</param>
        /// <param name="tile">Tile to put Player on</param>
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

        /// <summary>
        /// Sets the player tile
        /// </summary>
        /// <param name="tile">Tile to set the Player tile to</param>
        public void SetTile(AbstractTile tile)
        {
            IGameState powerUpTemp = tile.GetPowerUp();
            if (powerUpTemp != null)
            {
                this.powerUp = powerUpTemp;
            }
            currentTile = tile;
        }

        /// <summary>
        /// Return the tile the PLayer is on
        /// </summary>
        /// <returns></returns>
        public AbstractTile GetTile()
        {
            return currentTile;
        }

        /// <summary>
        /// Draw the Player
        /// </summary>
        /// <param name="spriteBatch">The spritebatch object used to draw the Player</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle outline = currentTile.Outline;

            spriteBatch.Draw(StaticTextures.Pixel, new Rectangle(outline.X + (int)(PlayerPieceOffset.X), outline.Y + (int)(PlayerPieceOffset.Y), outline.Width / 2, outline.Height / 2), Color);
        }

        /// <summary>
        /// has a player draw their stats: their name, what number attempt they are on, their total score, and what powerup, if any, they are currently using
        /// </summary>
        /// <param name="spriteBatch">the spritebatch for where the player should display their stats</param>
        public void DrawStats(SpriteBatch spriteBatch)
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

        /// <summary>
        /// allows a player to display their name and score
        /// </summary>
        /// <param name="spriteBatch">the spritebatch where the player will displayer their name and score</param>
        /// <param name="i">which player this specific player is, used to determine y-position of score</param>
        /// <param name="offset">offset for the x-coordinate, so the player doesn't display too far or too close to the side of the window</param>
        public void DrawScore(SpriteBatch spriteBatch, int i, int offset)
        {
            String playerScoreText = ": " + totalScore;
            Vector2 playerNameSize = StaticFonts.PericlesFont18.MeasureString(Name);

            Vector2 nameLoc = new Vector2(offset, playerNameSize.Y * i);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, Name, nameLoc, Color);
            Vector2 scoreLoc = new Vector2(offset + (int)playerNameSize.X, (int)nameLoc.Y);
            spriteBatch.DrawString(StaticFonts.PericlesFont18, playerScoreText, scoreLoc, Color.Orange);
        }

        /// <summary>
        /// Return the name of the powerup the Player has currently
        /// </summary>
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

        /// <summary>
        /// Use the powerup that the player is holding
        /// </summary>
        /// <returns></returns>
        public IGameState ConsumePowerUp()
        {
            IGameState powerUpTemp = this.powerUp;
            this.powerUp = null;
            return powerUpTemp;
        }
    }
}
