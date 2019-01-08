https://www.codewars.com/kata/581de9a5b7bad5d369000150

function dayPlan (hours, tasks, duration){
  var totalMinutes = hours * 60;
  var xtraTime = totalMinutes - tasks*duration;
  var workTime = tasks*duration;
  var schedule =[];
  var breakTime = Math.round(xtraTime/ (tasks-1));
  if (tasks == 0) {
    return schedule;
    }
  if (xtraTime <0) {
    return ("You're not sleeping tonight!")
    }
  else {
    for (var i=1; i< tasks; i++) {
      schedule.push(duration);
      schedule.push(breakTime);
    }
    schedule.push(duration);
  }
  return schedule;
}

//Test Cases:

Test.assertSimilar(dayPlan(8, 5, 30), [ 30, 83, 30, 83, 30, 83, 30, 83, 30 ]);
Test.assertSimilar(dayPlan(2,2,60), [ 60, 0, 60 ]);
Test.assertSimilar(dayPlan(3,5,60), 'You\'re not sleeping tonight!');
