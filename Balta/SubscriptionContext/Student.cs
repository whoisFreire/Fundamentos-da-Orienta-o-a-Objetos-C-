﻿using System.Collections.Generic;
using System.Linq;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(subscription => !subscription.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "Usuário já tem uma assinatura ativa"));
                return;
            }
            Subscriptions.Add(subscription);
        }
    }
}