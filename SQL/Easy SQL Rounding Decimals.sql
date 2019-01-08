/*https://www.codewars.com/kata/594a6133704e4daf5d00003d*/

select FLOOR(number1) as number1, CEILING(number2) as number2 from decimals;

/*Test Cases in Ruby

results = run_sql

describe :query do
  describe "should contain keywords" do
    it "should contain SELECT" do
      expect($sql.upcase).to include("SELECT")
    end

    it "should contain FROM" do
      expect($sql.upcase).to include("FROM")
    end
  end

  describe :columns do
    it "should return 2 columns" do
      expect(results.first.keys.count).to eq 2
    end
    
    it "should return a number1 column" do
      expect(results.first.keys).to include(:number1)
    end
    
    it "should return a number2 column" do
      expect(results.first.keys).to include(:number2)
    end
 end
end
*/