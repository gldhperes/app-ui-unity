## Organização das pastas
- Coloquei os arquivos pertinentes ao projeto na pasta UIToolkit dentro de assests.
- Separei por categorias, como: fontes, imagens, scripts, SO_prefabs, USS, UXML Templates.
 - Fontes: Fonte usada nos textos.
 - Imagens: Imagens dos itens.
 - Scripts: Scripts referente ao Shop no padrão MVVM.
 - SO_Prefabs: Contem Scripts para a criação dos ScriptablesObjects, bem como a pastar para esses objetos.
  - O intuito foi criar pré-fabricados dos itens do jogo, assim se uma nova categoria de Itens for cirada, pode-se usar o mesmo padrão.
 - USS: Contem os codigos de CSS do Shop.
 - UXML Templates: Contem a pasta para cada tela de jogo, neste caso Shop, que contem os templates de UXML.


## Breve explicação do Design da tela do Shop
 - No Header coloquei para seus elementos se organizassem no centro e inseri duas "divs" uma com tamanho fixo "div1" e outra com tamanho 100% "div2", isso possibilita um espaçao entre  ambas mesmo que a tela diminua um pouco.
 - Abaixo do Header fiz uma "div" contendo uma altura com 10% e o alinhamento do item para a esquerda-baixo.
 - Na parte principal onde ficam os Cards dos itens, coloquei um grande painel, que contem 2 ScrollViewrs, podendo conter mais de acordo com os tipos de item, coloquei-os com width de 100%, pois eles ficarão visiveis por meio de Script.
 - Por fim na parte de baixo fiz uma "div" com tamanho de 80% para se ajustar a telas menore e contendo os boçoes de interação para cada tipo de item.

## Explicação dos Scripts
### SO_Item
Dentro da pasta _SO_Prefabs_ há o arquivo SO_Item que é o responsavel pela criação de um item/card contendo todas suas informações/imagens utilizadas : imagem, card, union, raridade, info, preço.
SO_Item tambem serve para ser herdado de um script que tenha essas caracteristicas, como SO_Cars e SO_Itens, em que ambos estão vazios, apenas contendo essa heranaça e a criação de um _AssetMenu_ , o intuito disso é apenas para a diferenciação de tipos.

### Shop Scripts
Os scripts do Shop estao contidos na pasta de scripts/shop e estão atribuidos ao UI Document da tela de SHOP. Eles são Shop_View, Shop_Modelview, Shop_Model. 
- Shop_View pões elementos em tela.
- Shop_Modelview recebe delegações da view ou model, prepara alguns elementos visuais e os devolve.
- Shop_Model recebe requisitos repassados de modelview e os retorna

Inicialmente em _Shop_View_ é iniciado a lista dos Scrollviewers "itens_content" (onde ficaram os cards dos itens), e inserido essas listas, `cars-content` e `parts-content`.
Em seguida é atribuido os botões de interação com os usuarios no menu de baixo e ativado o um botão, no caso, `cars-btn`.
Logo após é chamada as duas funções para colocar os itens em tela representadas pelos nomes `Set_Cars()` e `Set_Parts()`, ambas com comportamento semelhantes.

As duas possuem um variavel do tipo `List<VisualElement>` que fará uma chamada para `Shop_Modelview.Set_Cars()`, ou `Set_Parts()`, que por sua vez fará uma chamada para o `Shop_Model()` pegar uma lista de itens feitos, a partir do prefab de SO_Cars ou SO_Parts.
Após o retorno desta lista em `Shop_View` cada item é adicionado ao conteúdo da parte designada.

