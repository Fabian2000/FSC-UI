# FSC-UI
Custom modern UI Library for Windows Forms Applications

Available in Nuget Store: https://www.nuget.org/packages/FSC-UI/

---

Use the Controls and custom form directly out of your toolbox. 
To use the code in your form, import the namespaces: 

```cs
using FSC_UI;
using FSC_UI.Controls;
```

To Change the window into the FSC-UI window, change:
`public partial class Form1 : Form` to `public partial class Form1 : FSC`

All available Controls start with FSC[CONTROL_NAME]

A matching custom messagebox is included: FSCMessageBox.Show(...);

FSC-UI contains a ThemeBuilder and a ThemeLoader class to Load / Save / Create Themes
