using ScooterRental;

public class RentalRecordService : IRentalRecordService
{
    private List<RentedScooter> _rentedScooterList;

    public RentalRecordService(List<RentedScooter> rentedScooterList)
    {
        _rentedScooterList = rentedScooterList;
    }

    public List<RentedScooter> RentedScootersList
    {
        get { return _rentedScooterList; }
        set { _rentedScooterList = value; }
    }

    public void StartRent(string id, DateTime rentStart)
    {
        _rentedScooterList.Add(new RentedScooter(id, rentStart));
    }

    public RentedScooter StopRent(string id, DateTime rentEnd)
    {
        var rentalRecord = _rentedScooterList.FirstOrDefault(s => s.Id == id && !s.RentEnd.HasValue);
        if (rentalRecord != null)
        {
            rentalRecord.RentEnd = rentEnd;
        }
        return rentalRecord;
    }
}