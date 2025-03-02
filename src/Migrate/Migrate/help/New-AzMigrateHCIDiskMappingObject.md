---
external help file: Az.Migrate-help.xml
Module Name: Az.Migrate
online version: https://learn.microsoft.com/powershell/module/az.migrate/new-azmigratehcidiskmappingobject
schema: 2.0.0
---

# New-AzMigrateHCIDiskMappingObject

## SYNOPSIS
Creates a new disk mapping

## SYNTAX

```
New-AzMigrateHCIDiskMappingObject -DiskID <String> -IsOSDisk <String> -IsDynamic <String> -Size <Int64>
 -Format <String> [<CommonParameters>]
```

## DESCRIPTION
The New-AzMigrateHCIDiskMappingObject cmdlet creates a mapping of the source disk attached to the server to be migrated

## EXAMPLES

### EXAMPLE 1
```
New-AzMigrateHCIDiskMappingObject -DiskID a -IsOSDisk true -IsDynamic true -Size 1 -Format VHDX
```

## PARAMETERS

### -DiskID
Specifies the disk ID of the disk attached to the discovered server to be migrated.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Format
Specifies the disk format.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsDynamic
Specifies whether the disk is dynamic.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsOSDisk
Specifies whether the disk contains the Operating System for the source server to be migrated.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Size
Specifies the disk size in GB.

```yaml
Type: Int64
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.AzStackHCIDiskInput
## NOTES

## RELATED LINKS

[https://learn.microsoft.com/powershell/module/az.migrate/new-azmigratehcidiskmappingobject](https://learn.microsoft.com/powershell/module/az.migrate/new-azmigratehcidiskmappingobject)

