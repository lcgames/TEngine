﻿namespace TEngineCore
{
    /// <summary>
    /// ECS构架可以将此组件从Entity上移除这个组件并丢入对象池，给其他此刻需要此组件的Entity使用，
    /// 因此可以节省大量的内存反复创建和释放， 这也是ECS的特性可以大量重复使用组件
    /// </summary>
    public class ECSComponent:ECSObject
    {
#pragma warning disable IDE1006 
        public Entity Entity { get; set; }
#pragma warning restore IDE1006 
    }
}

