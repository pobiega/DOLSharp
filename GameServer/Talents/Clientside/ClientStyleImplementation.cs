﻿using System;

namespace DOL.Talents.Clientside
{
    /// <summary>
    /// Implements a talent as a style
    /// </summary>
    public class ClientStyleImplementation : ITalentClientImplementation
    {
        public byte Level { get; set; }
        public ushort InternalID { get; set; }
        public ushort Requirement { get; set; }
        public ushort Icon { get; set; }
        public String Name { get; set; }

        /// <summary>
        /// Group under which this skill sits. Can be null.
        /// </summary>
        public SkillGroupTalent SkillGroup { get; set; }
    }
}
