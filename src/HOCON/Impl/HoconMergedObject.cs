﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hocon
{
    public sealed class HoconMergedObject:HoconObject
    {
        public List<HoconObject> Objects { get; }

        public HoconMergedObject(IHoconElement parent, List<HoconObject> objects) : base(parent)
        {
            Objects = objects;
            foreach (var obj in objects)
            {
                base.Merge(obj);
            }
        }

        public override void Merge(HoconObject other)
        {
            ((HoconField)Parent).Value.Add(other.Clone(((HoconField)Parent).Value));
            base.Merge(other);
        }
    }
}
