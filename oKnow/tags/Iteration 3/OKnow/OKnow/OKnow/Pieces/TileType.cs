using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
namespace OKnow
{
    //Enum for the type of tile this is
    public enum TileType
    {
        NONE = 0,
        STANDARD = 1,
        DEATH = 2,
        END = 3,
        EYE = 4,
        JOKER = 5,
        MUSIC = 6,
        START = 7,
        TIMED = 8
    }

    public class TileTypeTextures
    {
        static Texture2D banjoKazooieTile;
        static Texture2D deathTile;
        static Texture2D endTile;
        static Texture2D eyeTile;
        static Texture2D jokerTile;
        static Texture2D musicTile;
        static Texture2D startTile;
        static Texture2D timedTile;

        public static void LoadContent(ContentManager Content)
        {
            banjoKazooieTile = Content.Load<Texture2D>("Graphics/BanjoKazooieTile");
            deathTile = Content.Load<Texture2D>("Graphics/DeathTile");
            endTile = Content.Load<Texture2D>("Graphics/EndTile");
            eyeTile = Content.Load<Texture2D>("Graphics/eyeTile");
            jokerTile = Content.Load<Texture2D>("Graphics/jokerTile");
            musicTile = Content.Load<Texture2D>("Graphics/MusicTile");
            startTile = Content.Load<Texture2D>("Graphics/StartTile");
            timedTile = Content.Load<Texture2D>("Graphics/TimedTile");
        }

        public static Texture2D getTileGraphic(TileType tileType)
        {
            if (tileType == TileType.NONE)
            {
                return null;
            }
            else if (tileType == TileType.STANDARD)
            {
                return banjoKazooieTile;
            }
            else if (tileType == TileType.DEATH)
            {
                return deathTile;
            }
            else if (tileType == TileType.END)
            {
                return endTile;
            }
            else if (tileType == TileType.EYE)
            {
                return eyeTile;
            }
            else if (tileType == TileType.JOKER)
            {
                return jokerTile;
            }
            else if (tileType == TileType.MUSIC)
            {
                return musicTile;
            }
            else if (tileType == TileType.START)
            {
                return startTile;
            }
            else if (tileType == TileType.TIMED)
            {
                return timedTile;
            }
            else
            {
                return null;
            }
        }
    }
}
