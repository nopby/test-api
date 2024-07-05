using BETest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BETest.Persistences.Configurations;

internal sealed class SimulationEntityConfiguration : IEntityTypeConfiguration<Simulation>
{
    public void Configure(EntityTypeBuilder<Simulation> builder)
    {
        builder.ToTable("TB_SIMULATION")
            .HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("Id_simulasi").ValueGeneratedOnAdd();
        builder.Property(x => x.KodeBarang).HasColumnName("Kode_barang");
        builder.Property(x => x.UraianBarang).HasColumnName("Uraian_barang");
        builder.Property(x => x.Bm);
        builder.Property(x => x.NilaiKomoditas).HasColumnName("Nilai_komoditas");
        builder.Property(x => x.NilaiBm).HasColumnName("Nilai_bm");
        builder.Property(x => x.WaktuInsert).HasColumnName("Waktu_insert")
            .ValueGeneratedOnAdd()
            .HasDefaultValue(DateTime.UtcNow);
    }
}
