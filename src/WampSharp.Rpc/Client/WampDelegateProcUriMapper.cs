﻿using System;
using System.Reflection;

namespace WampSharp.Rpc
{
    public class WampDelegateProcUriMapper : IWampProcUriMapper
    {
        private readonly Func<MethodInfo, string> mMethodMapper;

        public WampDelegateProcUriMapper(Func<MethodInfo, string> methodMapper)
        {
            mMethodMapper = methodMapper;
        }

        public string Map(MethodInfo method)
        {
            return mMethodMapper(method);
        }
    }
}