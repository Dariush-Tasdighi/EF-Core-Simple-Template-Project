using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Seedwork;

public abstract class Entity() : object()
{
	[Key]
	[Browsable(browsable: false)]
	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public Guid Id { get; private set; } = Guid.NewGuid();

	[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
	public DateTimeOffset InsertDateTime { get; private set; } = DateTime.Now;
}
