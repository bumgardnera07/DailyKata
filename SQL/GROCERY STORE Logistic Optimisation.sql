/*https://www.codewars.com/kata/5a8ec692b17101bfc70001ba*/

SELECT producer, COUNT(id) as unique_products
FROM products
GROUP BY producer
ORDER BY unique_products DESC, producer ASC

/*Test in RUBY RSpec

results = run_sql

describe :query do
  describe :syntax do
    it "should contain SELECT" do
      expect($sql.upcase).to include("SELECT")
    end
    
    it "should contain GROUP BY" do
      expect($sql.upcase).to include("GROUP BY")
    end
    
    it "should order results" do
      expect($sql.upcase).to include("ORDER BY")
    end
  end

  describe :columns do
    it "should return 2 columns" do
      expect(results.first.keys.count).to eq 2
    end
    
    it "should contain unique_products column" do
      expect(results.first.keys).to include(:unique_products)
    end
    
    it "should contain producer column" do
      expect(results.first.keys).to include(:producer)
    end
  end
end
*/