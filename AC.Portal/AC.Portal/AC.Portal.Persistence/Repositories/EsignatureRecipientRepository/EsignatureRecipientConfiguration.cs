using AC.Portal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AC.Portal.Persistence.Repositories.EsignatureRecipientRepository
{
    public class EsignatureRecipientConfiguration : IEntityTypeConfiguration<EsignatureRecipient>
    {
        public void Configure(EntityTypeBuilder<EsignatureRecipient> builder)
        {
            builder.ToTable("EsignatureRecipient");

            builder.HasKey(o => o.Id);

            builder.Property(c => c.EsignatureEnvelopeId)
                .HasColumnName("EsignatureEnvelopeId");

            builder.Property(c => c.Name)
                .HasColumnName("Name");

            builder.Property(c => c.ClientNumber)
                .HasColumnName("ClientNumber")
                .IsRequired(false);

            builder.Property(c => c.DocuSignRecipientId)
                .HasColumnName("DocuSignRecipientId")
                .IsRequired(false);

            builder.Property(c => c.SentDateTime)
                .HasColumnName("SentDateTime")
                .IsRequired(false);

            builder.Property(c => c.DeliveredDateTime)
                .HasColumnName("DeliveredDateTime")
                .IsRequired(false);

            builder.Property(c => c.SignedDateTime)
                .HasColumnName("SignedDateTime")
                .IsRequired(false);

            builder.Property(c => c.Status)
                .HasColumnName("Status")
                .IsRequired(false);

            builder.Property(c => c.ModifiedBy)
                .HasColumnName("ModifiedBy");
        }

    }
}
