using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace OKnow
{
    public class Player
    {

        private static int nextPlayerID = 0;
        private static Color[] playerColors = new Color[] { Color.Red, Color.Purple, Color.Green, Color.Yellow };
        private static Vector2[] playerPieceOffset = new Vector2[] { new Vector2(0, 0),
                                                                    new Vector2(Tile.tileLength / 2, 0), 
                                                                    new Vector2(0, Tile.tileLength / 2),
                                                                    new Vector2(Tile.tileLength / 2, Tile.tileLength / 2)};

        public static void Reset()
        {
            nextPlayerID = 0;
        }

        private String name;

        private Tile currentTile;
        private int playerID;


        public static int MaxPlayers
        {
            get { return 4; }
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

        public Player(Tile tile) : this("Player" + (nextPlayerID+1), tile){}

        public Player(String name, Tile tile)
        {
            if (nextPlayerID >= MaxPlayers)
            {
                throw new Exception("More then 4 players have been created.");
            }
            playerID = nextPlayerID;
            this.name = name;
            currentTile = tile;

            nextPlayerID++;
        }

        public void setTile(Tile tile)
        {
            currentTile = tile;
        }

        public Tile getTile()
        {
            return currentTile;
        }

        public void draw(SpriteBatch spriteBatch)
        {
            Texture2D pixel = Game1.getSingleton().getPixel();
            Rectangle outline = currentTile.Outline;

            spriteBatch.Draw(pixel, new Rectangle(outline.X + (int)(PlayerPieceOffset.X), outline.Y + (int)(PlayerPieceOffset.Y), outline.Width / 2, outline.Height / 2), Color);
        }
    }
}
