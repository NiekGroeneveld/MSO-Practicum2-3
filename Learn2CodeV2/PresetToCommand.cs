using System;
using System.Collections.Generic;


namespace Learn2CodeV2
{
    public enum PresetLevel
    {
        Basic,
        Advanced,
        Expert
    }

    public class PresetToCommand
    {
        private static readonly Dictionary<PresetLevel, string[]> PresetCommands;

        static PresetToCommand()
        {
            PresetCommands = new Dictionary<PresetLevel, string[]>
            {
                {
                    PresetLevel.Basic,
                    new string[]
                    {
                        "Move 10",
                        "Turn right",
                        "Move 10",
                        "Turn right",
                        "Move 10",
                        "Turn right",
                        "Move 10",
                        "Turn right"
                    }
                },
                {
                    PresetLevel.Advanced,
                    new string[]
                    {
                        "Repeat 4 times",
                        " Move 10",
                        " Turn right"
                    }
                },
                {
                    PresetLevel.Expert,
                    new string[]
                    {
                        "Move 5",
                        "Turn left",
                        "Turn left",
                        "Move 3",
                        "Turn right",
                        "Repeat 3 times",
                        " Move 1",
                        " Turn right",
                        " Repeat 5 times",
                        "  Move 2",
                        "Turn left"
                    }
                }
            };
        }

        public string[] GetPreset(string level)
        {
            if (string.IsNullOrWhiteSpace(level))
            {
                throw new ArgumentNullException(nameof(level), "Preset level cannot be null or empty");
            }

            if (Enum.TryParse(level, true, out PresetLevel presetLevel))
            {
                return PresetCommands[presetLevel];
            }

            throw new ArgumentException($"Invalid preset level: {level}", nameof(level));
        }


    }
}

   