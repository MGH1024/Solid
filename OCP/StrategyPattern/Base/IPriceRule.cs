﻿namespace OCP.StrategyPattern.Base;

public interface IPriceRule
{
    bool IsMatch(OrderItem item);
    decimal CalculatePrice(OrderItem item);
}