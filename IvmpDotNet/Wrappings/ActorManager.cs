﻿using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class ActorManager : IActorManager {
        public IActor Create(int iModelId, CVector3 vecPosition, float fHeading) {
            ushort id = Imports.Actors.Actors_Create(iModelId, vecPosition, fHeading);
            return new Actor() {
                ActorId = id
            };
        }
    }
}
