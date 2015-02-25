class Countries
{
    private string name;
    private double gdpGrowth;
    private double inflation;
    private double tradeBalance;
    private int hdiRank;
    private string tradePartners;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double GdpGrowth
    {
        get { return gdpGrowth; }
        set { gdpGrowth = value; }
    }

    public double Inflation
    {
        get { return inflation; }
        set { inflation = value; }
    }

    public double TradeBalance
    {
        get { return tradeBalance; }
        set { tradeBalance = value; }
    }

    public int HdiRank
    {
        get { return hdiRank; }
        set { hdiRank = value; }
    }

    public string TradePartners
    {
        get { return tradePartners; }
        set { tradePartners = value; }
    }
}