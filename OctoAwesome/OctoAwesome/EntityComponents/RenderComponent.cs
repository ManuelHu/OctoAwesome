﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoAwesome.EntityComponents
{
    public class RenderComponent : EntityComponent
    {
        public string Name { get; set; }
        public string ModelName { get; set; }
        public string TextureName { get; set; }

        public float BaseZRotation { get; set; }

        public RenderComponent()
        {
            Sendable = true;
        }

        public override void Serialize(BinaryWriter writer, IDefinitionManager definitionManager)
        {
            writer.Write(Name);
            writer.Write(ModelName);
            writer.Write(TextureName);
            writer.Write(BaseZRotation);
            base.Serialize(writer, definitionManager);
        }

        public override void Deserialize(BinaryReader reader, IDefinitionManager definitionManager)
        {
            Name = reader.ReadString();
            ModelName = reader.ReadString();
            TextureName = reader.ReadString();
            BaseZRotation = reader.ReadSingle();
            base.Deserialize(reader, definitionManager);
        }
    }
}
