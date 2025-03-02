---
external help file: Az.StorageMover-help.xml
Module Name: Az.StorageMover
online version: https://learn.microsoft.com/powershell/module/az.storagemover/update-azstoragemoverazsmbfileshareendpoint
schema: 2.0.0
---

# Update-AzStorageMoverAzSmbFileShareEndpoint

## SYNOPSIS
Updates properties for a SMB file share endpoint resource.
Properties not specified in the request body will be unchanged.

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzStorageMoverAzSmbFileShareEndpoint -Name <String> -ResourceGroupName <String>
 -StorageMoverName <String> [-SubscriptionId <String>] [-Description <String>] [-DefaultProfile <PSObject>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzStorageMoverAzSmbFileShareEndpoint -InputObject <IStorageMoverIdentity> [-Description <String>]
 [-DefaultProfile <PSObject>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates properties for a SMB file share endpoint resource.
Properties not specified in the request body will be unchanged.

## EXAMPLES

### EXAMPLE 1
```
Update-AzStorageMoverAzSmbFileShareEndpoint -Name "myendpoint" -ResourceGroupName "myresourcegroup" -StorageMoverName "mystoragemover" -Description "updated endpoint"
```

### EXAMPLE 2
```
Get-AzStorageMoverEndpoint -ResourceGroupName "myresourcegroup" -StorageMoverName "mystoragemover" -Name "myendpoint" | Update-AzStorageMoverAzSmbFileShareEndpoint -Description "updated endpoint again"
```

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
A description for the endpoint.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IStorageMoverIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the endpoint resource.

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases: EndpointName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -StorageMoverName
The name of the Storage Mover resource.

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.IStorageMoverIdentity
## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20231001.IEndpoint
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IStorageMoverIdentity\>: Identity Parameter
  \[AgentName \<String\>\]: The name of the Agent resource.
  \[EndpointName \<String\>\]: The name of the Endpoint resource.
  \[Id \<String\>\]: Resource identity path
  \[JobDefinitionName \<String\>\]: The name of the Job Definition resource.
  \[JobRunName \<String\>\]: The name of the Job Run resource.
  \[ProjectName \<String\>\]: The name of the Project resource.
  \[ResourceGroupName \<String\>\]: The name of the resource group.
The name is case insensitive.
  \[StorageMoverName \<String\>\]: The name of the Storage Mover resource.
  \[SubscriptionId \<String\>\]: The ID of the target subscription.

## RELATED LINKS

[https://learn.microsoft.com/powershell/module/az.storagemover/update-azstoragemoverazsmbfileshareendpoint](https://learn.microsoft.com/powershell/module/az.storagemover/update-azstoragemoverazsmbfileshareendpoint)

