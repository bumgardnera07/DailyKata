/*https://www.codewars.com/kata/593ef0e98b90525e090000b9 */

SELECT tp.id, tp.heads, bot.legs, tp.arms, bot.tails, CASE WHEN tp.heads > tp.arms OR bot.tails > bot.legs THEN 'BEAST' ELSE 'WEIRDO' END AS species FROM top_half tp FULL OUTER JOIN bottom_half bot ON tp.id = bot.id ORDER BY species;

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

    it "should contain ORDER" do
      expect($sql.upcase).to include("ORDER")
    end

    it "should contain CASE" do
      expect($sql.upcase).to include("CASE")
    end

    it "should contain THEN" do
      expect($sql.upcase).to include("THEN")
    end
  end

  describe :columns do
    it "should return 6 columns" do
      expect(results.first.keys.count).to eq 6
    end
    
    it "should return an id column" do
      expect(results.first.keys).to include(:id)
    end
    
    it "should return a heads column" do
      expect(results.first.keys).to include(:heads)
    end
    
    it "should return an arms column" do
      expect(results.first.keys).to include(:arms)
    end

    it "should return a legs column" do
      expect(results.first.keys).to include(:legs)
    end

    it "should return a tails column" do
      expect(results.first.keys).to include(:tails)
    end

    it "should return a species column" do
      expect(results.first.keys).to include(:species)
    end
  end
end
  */