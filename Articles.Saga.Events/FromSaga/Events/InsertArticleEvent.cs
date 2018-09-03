﻿using Articles.Saga.Events.FromSaga.Events.Interfaces;
using System;
using Articles.Saga.Events.FromSaga.States;

namespace Articles.Saga.Events.FromSaga.Events
{
    public class InsertArticleEvent : IInsertArticleEvent
    {
        private readonly InsertArticleSagaState sagaState;

        public InsertArticleEvent(InsertArticleSagaState sagaState)
        {
            this.sagaState = sagaState;
        }

        public DateTime AddedDate => sagaState.AddedDate;
        public string AddedBy => sagaState.AddedBy;
        public Guid CategoryId => sagaState.CategoryId;
        public string Title => sagaState.Title;
        public string Abstract => sagaState.Abstract;
        public string Body => sagaState.Body;
        public string Country => sagaState.Country;
        public string State => sagaState.State;
        public string City => sagaState.City;
        public DateTime ReleaseDate => sagaState.ReleaseDate;
        public DateTime ExpireDate => sagaState.ExpireDate;
        public bool Approved => sagaState.Approved;
        public bool Listed => sagaState.Listed;
        public bool CommentsEnabled => sagaState.CommentsEnabled;
        public bool OnlyForMembers => sagaState.OnlyForMembers;
        public int ViewCount => sagaState.ViewCount;
        public int Votes => sagaState.Votes;
        public int TotalRating => sagaState.TotalRating;
    }
}
