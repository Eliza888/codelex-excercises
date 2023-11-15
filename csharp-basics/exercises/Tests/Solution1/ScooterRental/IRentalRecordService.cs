using ScooterRental;

public interface IRentalRecordService
{
    List<RentedScooter> RentedScootersList { get; set; }
    void StartRent(string id, DateTime rentStart);
    RentedScooter StopRent(string id, DateTime rentEnd);
}