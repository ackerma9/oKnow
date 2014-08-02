using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

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

        public static void setBanjoKazooieTile(Texture2D texture)
        {
            banjoKazooieTile = texture;
        }

        public static void setDeathTile(Texture2D texture)
        {
            deathTile = texture;
        }

        public static void setEndTile(Texture2D texture)
        {
            endTile = texture;
        }

        public static void setEyeTile(Texture2D texture)
        {
            eyeTile = texture;
        }

        public static void setJokerTile(Texture2D texture)
        {
            jokerTile = texture;
        }

        public static void setMusicTile(Texture2D texture)
        {
            musicTile = texture;
        }

        public static void setStartTile(Texture2D texture)
        {
            startTile = texture;
        }

        public static void setTimedTile(Texture2D texture)
        {
            timedTile = texture;
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
