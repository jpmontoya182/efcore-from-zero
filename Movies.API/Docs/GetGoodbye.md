# Get WeatherForecast

## Description

Lorem ipsum odor amet, consectetuer adipiscing elit. Primis aliquam convallis dapibus aenean mus augue himenaeos. Curae lacinia feugiat metus nascetur potenti. Sit lacus quisque elementum fringilla; justo potenti. Litora ridiculus non mollis, tempus cras nostra placerat. Sem morbi blandit ac nascetur ex maximus. Ac arcu luctus, duis praesent venenatis ultrices. Ultricies lobortis aenean iaculis est posuere cras torquent. Quam sagittis nulla ex justo posuere ut auctor fusce.

## Implementation
Laoreet id turpis eleifend arcu auctor lacus. Magnis varius amet metus arcu turpis. Nunc massa pharetra eget euismod hac. Arcu enim sapien ex bibendum maximus aliquam. Semper eros adipiscing nascetur varius; eleifend odio fringilla. Purus lectus orci dapibus rhoncus ac. Diam maecenas ut nulla curabitur purus. Parturient adipiscing dapibus velit luctus justo fringilla primis. Dis torquent nisi venenatis inceptos pharetra consequat!


```
  try
        {
            var methodInfo = context.MethodInfo;

            // Verifica si el método tiene el atributo `DocumentationFileAttribute`
            var docAttribute = methodInfo.GetCustomAttribute<DocumentationFileAttribute>();
            if (docAttribute != null && File.Exists(docAttribute.FilePath))
            {
                // Lee el contenido del archivo y lo usa como descripción
                var description = File.ReadAllText(docAttribute.FilePath);
                operation.Description = description;
            }
            else
            {
                operation.Description = "No se encontró documentación para este endpoint.";
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
```

- [x] Write the press release
- [ ] Update the website
- [ ] Contact the media

Mi himenaeos maecenas ac fringilla nullam commodo natoque pulvinar id. Bibendum rutrum odio sapien eu ac vestibulum ex pretium. Viverra risus magnis ornare pulvinar finibus. Diam hac accumsan fames parturient felis varius egestas viverra. Ultrices ligula mus quis penatibus litora arcu. Ipsum mus aptent inceptos cubilia nam. Ad class praesent nunc condimentum class class erat. Commodo justo nisi non sollicitudin; accumsan tristique pharetra mi. Sapien posuere ad ridiculus quisque; class rhoncus. Sit nisl arcu facilisis facilisi sem ex viverra praesent.


1. First item
2. Second item
3. Third item
    1. Indented item
    2. Indented item
4. Fourth item

Netus mattis tempor pellentesque consectetur neque nascetur. Pulvinar a condimentum fames curabitur quis torquent phasellus. Finibus viverra ex fusce, nascetur congue platea. Euismod luctus hendrerit sed fermentum pretium nostra tincidunt venenatis. Cursus non parturient finibus dignissim erat lacus. Pulvinar maximus dis sodales pellentesque; facilisi lectus maecenas feugiat. Pulvinar scelerisque habitant, praesent egestas sed mi platea metus pharetra. Ridiculus cras aliquam nascetur suscipit faucibus, fermentum nec nisi.


| Syntax | Description |
| ----------- | ----------- |
| Header | Title |
| Paragraph | Text |

