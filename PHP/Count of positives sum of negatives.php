/* Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers.

If the input array is empty or null, return an empty array.

Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
*/

function countPositivesSumNegatives($input) {
    if( $input == null) return array();
    $o = array(0,0);
    
    for ($x = 0; $x <= count($input); $x++)
    {
      if ($input[$x] < 0) $o[1] += $input[$x];
      elseif ($input[$x] > 0) $o[0]++;
    }
    ksort($o);
    return $o;
}

# Tests

class CountPositivesSumNegativesTestCases extends TestCase
{
    public function testExample() {
      $this->assertSame([10, -65], countPositivesSumNegatives([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]));
      $this->assertSame([8, -50], countPositivesSumNegatives([0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14]));
    }
}