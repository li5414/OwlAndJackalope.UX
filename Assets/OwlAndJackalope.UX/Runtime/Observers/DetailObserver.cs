﻿using OwlAndJackalope.UX.Runtime.Data;

namespace OwlAndJackalope.UX.Runtime.Observers
{
    [System.Serializable]
    public class DetailObserver : AbstractDetailObserver
    {
        public override IDetail Detail
        {
            get => _detail;
            protected set => _detail = value;
        }

        private IDetail _detail;
    }

    [System.Serializable]
    public class DetailObserver<T> : AbstractDetailObserver
    {
        public override IDetail Detail
        {
            get => _detail;
            protected set => _detail = value as IDetail<T>;
        }

        public T Value => IsSet ? _detail.GetValue() : default;

        private IDetail<T> _detail;
    }
}