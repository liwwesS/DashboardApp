using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

public class Balance
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; init; }

    public int Month { get; set; }

    public int Year { get; set; }

    public decimal BalanceAmount { get; set; }

	[NotMapped] // ���������, ��� ��� �������� �� ������ ���� ���������� � ������� ���� ������
	public string MonthName
	{
		get
		{
			return System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Month);
		}
	}
}