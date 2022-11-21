﻿namespace CurricullumVitae.Models
{
    public interface IUIObject
    {
        public int Id { get; set; }
        IUIObject MakeNew();
        void UpdateFrom(IUIObject obj);

    }
}
