using Piranha.Extend;
using Piranha.Extend.Fields;
using System;

namespace SimpleModule.Blocks
{
    /// <summary>
    /// Single column text block.
    /// </summary>
    [BlockType(Name = "Header", Category = "Content", Icon = "fas fa-heading", Component = "header-block")]
    public class HeaderBlock : Block
    {
        /// <summary>
        /// Gets/sets the text body.
        /// </summary>
        public StringField Body { get; set; }

        public override string GetTitle()
        {
            if (Body.Value != null)
            {
                return Body.Value;
            }
            return "Empty";
        }
    }
}
