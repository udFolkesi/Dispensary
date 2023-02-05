SELECT TOP 1 Discounts.DiscountType, COUNT(Discounts.DiscountType) FROM Accounts
INNER JOIN Discounts ON Discounts.DiscountID = Accounts.DiscountCode
INNER JOIN Habitations ON Habitations.HabitationID = Accounts.HabitationCode
WHERE Habitations.CheckInDate > (SELECT DATEADD(month, -1, GETDATE()))
GROUP BY Discounts.DiscountType
ORDER BY COUNT(Discounts.DiscountType) DESC;