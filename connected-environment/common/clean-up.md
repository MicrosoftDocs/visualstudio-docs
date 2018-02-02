## Clean Up
To completely delete a Connected Environment in Azure, including all the running services within it:

```cmd
vsce env list
vsce env rm --name <env-to-delete> --resource-group <env-resource-group>
```

