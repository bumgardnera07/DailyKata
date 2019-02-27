#https://www.codewars.com/kata/554a44516729e4d80b000012

# Let us begin with an example:
#A man has a rather old car being worth $2000. He saw a secondhand car being worth $8000. He wants to keep his old car until he can buy the secondhand one.
#He thinks he can save $1000 each month but the prices of his old car and of the new one decrease of 1.5 percent per month. Furthermore this percent of loss increases by 0.5 percent at the end of every two months. Our man finds it difficult to make all these calculations.
#Can you help him?
#How many months will it take him to save up enough money to buy the car he wants, and how much money will he have left over?
#Parameters and return of function:
#parameter (positive int, guaranteed) startPriceOld (Old car price)
#parameter (positive int, guaranteed) startPriceNew (New car price)
#parameter (positive int, guaranteed) savingperMonth 
#parameter (positive float or int, guaranteed) percentLossByMonth
#nbMonths(2000, 8000, 1000, 1.5) should return [6, 766] or (6, 766)
#where 6 is the number of months at the end of which he can buy the new car and 766 is the nearest integer to 766.158 (rounding 766.158 gives 766).

import math

def nbMonths(startPriceOld, startPriceNew, savingperMonth, percentLossByMonth):
    totalMoney = startPriceOld
    months = 0
    currentPriceNew = startPriceNew
    currentPriceOld = startPriceOld
    while totalMoney < currentPriceNew:
        months += 1
        currentPriceOld = currentPriceOld*(1-(percentLossByMonth*.01)-math.floor((months)/2)*.005)
        currentPriceNew = currentPriceNew*(1-(percentLossByMonth*.01)-math.floor((months)/2)*.005)
        totalMoney = currentPriceOld+savingperMonth*months
    return [months, round(totalMoney-currentPriceNew)]


test.assert_equals(nbMonths(2000, 8000, 1000, 1.5), [6, 766])
test.assert_equals(nbMonths(12000, 8000, 1000, 1.5) ,[0, 4000])