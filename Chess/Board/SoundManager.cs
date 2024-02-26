using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Board
{
    public class SoundManager
    {
            private SoundPlayer activePlayer;
            private Dictionary<SoundType, SoundPlayer> soundPlayers = new Dictionary<SoundType, SoundPlayer>();

            public SoundManager()
            {
                // Preload sounds
                PreloadSound(SoundType.RaiseFigure, Properties.Resources.raiseFigure);
                PreloadSound(SoundType.PlaceFigure, Properties.Resources.placeFigure);
                PreloadSound(SoundType.Promotion, Properties.Resources.promotion);
                PreloadSound(SoundType.Castling, Properties.Resources.castling);
                PreloadSound(SoundType.EnPassant, Properties.Resources.enPassant);
            }

            private void PreloadSound(SoundType soundName, System.IO.UnmanagedMemoryStream sound)
            {
                var player = new SoundPlayer(sound);
                player.Load(); // Preload sound
                soundPlayers[soundName] = player;
            }

            public void PlaySound(SoundType sound)
            {
                if (activePlayer != null)
                {
                    activePlayer.Stop();
                }
                if (soundPlayers.TryGetValue(sound, out var playerToPlay))
                {
                    activePlayer = playerToPlay;
                    activePlayer.Play();
                }
        }
    }
    public enum SoundType
    {
        RaiseFigure,
        PlaceFigure,
        Promotion,
        Castling,
        EnPassant
    }
}
