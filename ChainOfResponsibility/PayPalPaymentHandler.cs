﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer)
                Console.WriteLine("Выполняется перевод через PayPal");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
