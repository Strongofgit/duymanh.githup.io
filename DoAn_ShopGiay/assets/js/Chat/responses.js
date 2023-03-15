function getBotResponse(input) {

    //================================================ CHÀO HỎI =========================================================//

    if (input === ("hi shop") || input === ("xin chào") || input === ("chào shop") || input === ("shop ơi")
        || input === ("hello") || input === ("hello shop") || input === ("hi")) {
        return "Xin chào! Cảm ơn anh/chị đã quan tâm. Chúng tôi có thể giúp gì cho anh/chị ạ?";
    } else if (input === ("Hi shop") || input === ("Xin chào") || input === ("Chào shop") || input === ("Shop ơi")
        || input === ("Hello") || input === ("Hello shop") || input === ("Hi")) {
        return "Xin chào! Cảm ơn anh/chị đã quan tâm. Chúng tôi có thể giúp gì cho anh/chị ạ?";
    }
    //============================================================================================================================//



    //============================================= MỘT VẤN ĐỀ KHÁC ======================================================//

    if (input === "khác" || input === "tôi cần tư vấn vấn đề khác" || input === "tôi cần tư vấn về vấn đề khác" || input === "tôi cần tư vấn về một vấn đề khác" || input === "tôi cần tư vấn một vấn đề khác"
        || input === "tôi cần hỏi về vấn đề khác" || input === "tôi cần hỏi vấn đề khác" || input === "tôi cần hỏi một vấn đề khác" || input === "tôi muốn hỏi về vấn đề khác" || input === "tôi muốn hỏi vấn đề khác"
        || input === "vấn đề khác" || input === "một vấn đề khác" || input === "tôi muốn hỏi một vấn đề khác"
        || input === "mình cần tư vấn vấn đề khác" || input === "mình cần tư vấn về vấn đề khác" || input === "mình cần tư vấn về một vấn đề khác" || input === "mình cần tư vấn một vấn đề khác"
        || input === "mình cần hỏi về vấn đề khác" || input === "mình cần hỏi vấn đề khác" || input === "mình cần hỏi một vấn đề khác" || input === "mình muốn hỏi về vấn đề khác" || input === "mình muốn hỏivấn đề khác"
        || input === "em cần tư vấn vấn đề khác" || input === "em cần tư vấn về vấn đề khác" || input === "em cần tư vấn về một vấn đề khác" || input === "em cần tư vấn một vấn đề khác"
        || input === "em cần hỏi về vấn đề khác" || input === "em cần hỏi vấn đề khác" || input === "em cần hỏi một vấn đề khác" || input === "em muốn hỏi về vấn đề khác" || input === "em muốn hỏi vấn đề khác"
    ) {
        return "Anh/chị hãy đưa ra thắc mắc của mình."
    }
    if (input === ("cho em hỏi") || input === ("cho em hỏi chút") || input === ("em muốn hỏi cái này") || input === ("cho em hỏi cái này") || input === ("cho mình hỏi")
        || input === ("cho anh hỏi") || input === ("cho anh hỏi chút") || input === ("anh muốn hỏi cái này") || input === ("cho anh hỏi cái này") || input === ("cho anh hỏi")
        || input === ("cho chị hỏi") || input === ("cho chị hỏi chút") || input === ("chị muốn hỏi cái này") || input === ("cho chị hỏi cái này") || input === ("cho chị hỏi")
        || input === "cho hỏi" || input === "cho tôi hỏi" || input === "tôi muốn hỏi" || input === "cho mình hỏi" || input === "mình muốn hỏi"
    ) {
        return "Vâng ạ! Anh/chị hãy đưa ra câu hỏi hệ thống sẽ giúp mình giải đáp thắc mắc.";
    } else if (input === ("Cho em hỏi") || input === ("Em muốn hỏi cái này") || input === ("Cho em hỏi cái này")) {
        return "Vâng ạ! Anh/chị hãy đưa ra câu hỏi hệ thống sẽ giúp mình giải đáp thắc mắc.";
    }
    //========================================================================================================================//



    //============================================= TƯ VẤN VỀ GIÀY ===================================================//

    if (input === "tư vấn về giày" || input === "tôi cần tư vấn về giày" || input === "tư vấn cho tôi giày của shop" || input === "tôi muốn được tư vấn về giày" || input === "tôi cần hỏi về giày của shop" || input === "tôi muốn hỏi về giày" || input === "tôi muốn tư vấn về giày"
        || input === "tôi cần hỏi về giày" || input === "tôi cần hỏi giày" || input === "tư vấn giày" || input === "tư vấn giày của shop" || input === "tư vấn về giày của shop" || input === "tôi cần tư vấn giày" || input === "tôi muốn hỏi giày"
        || input === "mình cần tư vấn về giày" || input === "mình cần tư vấn về giày của shop" || input === "mình cần tư vấn về giày" || input === "mình muốn được tư vấn về giày" || input === "mình cần tư vấn về giày" || input === "tôi muốn tư vấn về giày"
        || input === "mình cần hỏi về giày" || input === "mình cần hỏi giày" || input === "mình cần hỏi về giày của shop" || input === "mình muốn hỏi về giày" || input === "mình muốn hỏi giày của shop" || input === "mình muốn tư vấn về giày" || input === "mình cần hỏi về giày"
        || input === "em cần tư vấn vấn đề giày" || input === "em cần tư vấn về vấn đề giày" || input === "em cần tư vấn giày" || input === "em cần tư vấn về giày của shop" || input === "em muốn hỏi về giày"
        || input === "em cần hỏi về giày" || input === "em cần hỏi vấn đề giày" || input === "em cần hỏi về vấn đề giày" || input === "em muốn hỏi về vấn đề giày" || input === "em muốn hỏi vấn đề giày" || input === "em muốn hỏi giày" || input === "em muốn tư vấn về giày"
        || input === "hãy tư vấn giày cho tôi" || input === "tư vấn cho tôi giày của bạn" || input === "tư vấn cho tôi giày của shop bạn" || input === "hãy tư vấn giày của shop bạn cho tôi" || input === "tôi muốn được tư vấn giày" || input === ""
        || input === "hãy tư vấn giày của cửa hàng bạn cho tôi" || input === "hãy tư vấn giày của shop bạn cho tôi" || input === "hãy tư vấn giày của cửa hàng cho tôi" || input === "hãy tư vấn giày của shop cho tôi"
        || input === "tư vấn giày của cửa hàng bạn cho tôi" || input === "tư vấn giày của shop bạn cho tôi" || input === "hãy tư vấn giày của cửa hàng cho tôi" || input === "tư vấn giày của shop cho tôi"
        || input === "hãy tư vấn giày mà cửa hàng bạn đang bán" || input === "hãy tư vấn giày của shop bạn đang bán" || input === "hãy tư vấn giày của cửa hàng bạn đang kinh doanh" || input === "hãy tư vấn giày của shop bạn đang kinh doanh"
        || input === "tôi muốn biết giày cửa hàng đang kinh doanh" || input === "tôi muốn biết giày cửa hàng đang bán" || input === "tôi muốn biết giày" || input === "tôi muốn biết về giày" || input === "tôi muốn biết thông tin giày cửa hàng đang kinh doanh"
        || input === "tư vấn giày cửa hàng bạn đang bán cho tôi" || input === "tư vấn giày cửa hàng bạn đang bán" || input === "tư vấn giày shop bạn đang bán cho tôi" || input === "tư vấn giày shop bạn đang bán"
        || input === "tư vấn cho tôi giày cửa hàng bạn đang kinh doanh" || input === "tư vấn cho tôi giày cửa hàng bạn đang bán" || input === "tư vấn cho tôi giày shop bạn đang bán" || input === "tư vấn cho tôi giày shop bạn đang bán"
        || input === "hãy tư vấn cho tôi" || input === "hãy tư vấn giày cho tôi" || input === "hãy tư vấn giày bạn đang bán cho tôi" || input === "hãy tư vấn giày bạn đang kinh doanh cho tôi" || input === "hãy tư vấn cho tôi giày bạn đang bán" || input === "hãy tư vấn cho tôi giày bạn đang kinh doanh"
        || input === "hãy tư vấn giày mà cửa hàng bạn đang bán cho tôi" || input === "hãy tư vấn cho tôi giày mà shop bạn đang bán" || input === "hãy tư vấn cho tôi giày của cửa hàng bạn đang kinh doanh" || input === "hãy tư vấn giày mà shop bạn đang kinh doanh"
        || input === "tôi muốn biết giày cửa hàng đang kinh doanh" || input === "tôi muốn biết giày cửa hàng kinh doanh" || input === "tôi muốn biết về giày cửa hàng đang bán" || input === "tôi muốn biết về giày mà shop bạn đang bán" || input === "tôi muốn biết thông tin giày mà cửa hàng bạn đang kinh doanh"
        || input === "tư vấn cho tôi giày mà cửa hàng bạn đang bán" || input === "tư vấn giày mà cửa hàng bạn đang bán" || input === "tư vấn cho tôi giày shop bạn đang bán" || input === "tư vấn giày shop bạn đang báncho tôi"
        || input === "tư vấn cho tôi giày cửa hàng bạn đang kinh doanh" || input === "tư vấn cho tôi giày cửa hàng bạn kinh doanh" || input === "tư vấn cho tôi giày shop bạn kinh doanh" || input === "tư vấn cho tôi giày cửa hàng bạn đang bán"
        || input === "hãy tư vấn cho tôi giày của shop" || input === "hãy tư vấn giày của shop cho tôi" || input === "hãy tư vấn giày shop đang bán cho tôi" || input === "hãy tư vấn giày cửa hàng đang kinh doanh cho tôi" || input === "hãy tư vấn cho tôi giày shop đang bán" || input === "hãy tư vấn cho tôi giày cửa hàng đang kinh doanh"
        || input === "hãy tư vấn giày cửa hàng đang bán" || input === "hãy tư vấn giày shop đang bán" || input === "hãy tư vấn giày cửa hàng đang kinh doanh" || input === "hãy tư vấn giày shop đang kinh doanh"
        || input === "tôi muốn biết giày cửa hàng bạn đang kinh doanh" || input === "tôi muốn biết giày cửa hàng đang kinh doanh" || input === "tôi muốn biết giày cửa hàng đang bán" || input === "tôi muốn biết giày mà shop bạn đang bán" || input === "tôi muốn biết thông tin giày cửa hàng đang kinh doanh"
        || input === "tư vấn cho tôi giày cửa hàng bạn đang bán" || input === "tư vấn giày cửa hàng bạn đang bán" || input === "tư vấn giày shop đang bán" || input === "tư vấn giày shop bạn đang bán"
        || input === "tư vấn cho tôi giày shop bạn đang kinh doanh" || input === "tư vấn cho tôi giày cửa hàng đang kinh doanh" || input === "tư vấn cho tôi giày shop đang kinh doanh" || input === "tư vấn giày cửa hàng bạn đang bán cho tôi"
        || input === "hãy tư vấn cho tôi giày shop đang bán" || input === "hãy tư vấn giày shop đang bán cho tôi" || input === "hãy tư vấn giày shop đang kinh doanh" || input === "hãy tư vấn cho tôi giày cửa hàng đang kinh doanh" || input === "hãy tư vấn giày shop bạn đang bán cho tôi" || input === "hãy tư vấn giày cửa hàng đang kinh doanh cho tôi"
        || input === "cho tôi biết một số giày shop đang bán" || input === "cho tôi biết giày shop đang bán" || input === "cho tôi biết một số giày cửa hàng đang bán" || input === "cho tôi biết giày cửa hàng đang bán" || input === "cho tôi biết một số giày shop bạn đang bán"
        || input === "cho tôi biết giày shop bạn đang bán" || input === "cho tôi biết một số giày cửa hàng bạn đang bán" || input === "cho tôi biết giày cửa hàng bạn đang bán"
    ) {
        return "Hiện tại, shop có bán giày của 3 hãng Nike, Jordan và Adidas.<br/>Có 4 loại cho anh/chị lựa chọn là: Custom, Street, Sneaker và Comfort.<br/>Shop có đầy đủ size từ 30 đến 46. Thông tin chi tiết anh/chị vui lòng tham khảo tại https://localhost:44379/.<br/>Xin cảm ơn!"
    }
    //=========================================================================================================================//

    //=========================================================================================================================//

    //========================================================================================================================//

    //================================================= TƯ VẤN VỀ HÃNG ==============================================//

    if (input === "tư vấn về hãng" || input === "tôi cần tư vấn về hãng" || input === "tư vấn cho tôi hãng giày của shop" || input === "tôi muốn được tư vấn về hãng sản xuất" || input === "tôi cần hỏi về hãng giày của shop" || input === "tôi muốn hỏi về hãng" || input === "tôi muốn tư vấn về hãng"
        || input === "tư vấn về hãng sản xuất" || input === "tôi cần tư vấn về hãng sản xuất" || input === "tư vấn cho tôi hãng sản xuất" || input === "tôi muốn được tư vấn về hãng sản xuất" || input === "tôi cần hỏi về hãng sản xuất" || input === "tôi muốn hỏi về hãng sản xuất" || input === "tôi muốn tư vấn về hãng sản xuất"
        || input === "tôi cần hỏi về hãng" || input === "tôi cần hỏi hãng" || input === "tư vấn hãng" || input === "tư vấn hãng giày" || input === "tư vấn về hãng giày" || input === "tôi cần tư vấn hãng" || input === "tôi muốn hỏi giày" || input === "tôi cần tư vấn về hãng giày"
        || input === "mình cần tư vấn về hãng giày" || input === "mình cần tư vấn về hãng" || input === "mình cần tư vấn về hãng sản xuất" || input === "mình muốn được tư vấn về hãng giày" || input === "mình cần tư vấn về hãng giày" || input === "tôi muốn tư vấn về hãng giày"
        || input === "mình cần tư vấn về hãng" || input === "mình cần tư vấn về hãng" || input === "mình muốn được tư vấn về hãng" || input === "mình cần tư vấn về hãng" || input === "tôi muốn tư vấn về hãng" || input === "em muốn được tư vấn về hãng giày"
        || input === "mình cần hỏi về hãng giày" || input === "mình cần hỏi về hãng giày" || input === "mình cần hỏi về hãng giày của shop" || input === "mình muốn hỏi về hãng sản xuất" || input === "mình muốn hỏi về hãng giày" || input === "mình muốn tư vấn về hãng giày" || input === "mình cần hỏi về hãng giày"
        || input === "mình cần hỏi về hãng sản xuất" || input === "mình cần hỏi mình cần hỏi về hãng" || input === "mình cần hỏi về hãng của shop" || input === "mình muốn hỏi về hãng giày" || input === "mình muốn hỏi về hãng" || input === "mình muốn tư vấn về hãng" || input === "mình cần hỏi về hãng"
        || input === "em cần tư vấn về hãng" || input === "em cần tư vấn về hãng giày" || input === "em cần tư vấn hãng" || input === "em cần tư vấn về hãng giày của shop" || input === "em muốn hỏi về giày" || input === "em muốn được tư vấn về hãng" || input === "em muốn được tư vấn về hãng sản xuất"
        || input === "em cần hỏi về hãng" || input === "em cần hỏi về hãng giày" || input === "em cần hỏi về vấn đề hãng giày" || input === "em muốn hỏi về hãng sản xuất" || input === "em muốn hỏi vấn đề giày" || input === "em muốn hỏi hãng giày" || input === "em muốn tư vấn về hãng giày"
        || input === "hãy tư vấn hãng giày cho tôi" || input === "tư vấn cho tôi hãng giày của bạn" || input === "tư vấn cho tôi hãng giày của shop bạn" || input === "hãy tư vấn hãng giày của shop bạn cho tôi" || input === "tôi muốn được tư vấn về hãng giày" || input === "tôi muốn được tư vấn về hãng"
        || input === "tư vấn cho tôi về hãng giày bạn bán" || input === "cho tôi biết một số hãng giày của shop" || input === "cho tôi biết một số hãng giày của shop đang bán" || input === "cho tôi biết một số hãng giày của shop bán"
        || input === "hãy tư vấn hãng giày của cửa hàng bạn cho tôi" || input === "hãy tư vấn hãng giày của shop bạn cho tôi" || input === "hãy tư vấn hãng giày của cửa hàng cho tôi" || input === "hãy tư vấn hãng giày của shop cho tôi"
        || input === "tư vấn hãng giày của cửa hàng bạn cho tôi" || input === "tư vấn hãng giày của shop bạn cho tôi" || input === "hãy tư vấn hãng giày của cửa hàng cho tôi" || input === "tư vấn hãng giày của shop cho tôi"
        || input === "hãy tư vấn hãng giày mà cửa hàng bạn đang bán" || input === "hãy tư vấn hãng giày của shop bạn đang bán" || input === "hãy tư vấn hãng giày của cửa hàng bạn đang kinh doanh" || input === "hãy tư vấn hãy giày của shop bạn đang kinh doanh"
        || input === "tôi muốn biết hãng giày cửa hàng đang kinh doanh" || input === "tôi muốn biết hãng giày cửa hàng đang bán" || input === "tôi muốn biết hãng" || input === "tôi muốn biết về hãng giày" || input === "tôi muốn biết thông tin hãng giày cửa hàng đang kinh doanh"
        || input === "cho tôi biết một số hãng giày của shop bạn"
    ) {
        return "Cửa hàng có bán giày của 3 hãng Nike, Jordan và Adidas.<br/>Thông tin chi tiết anh/chị vui lòng tham khảo tại https://localhost:44379/.<br/>Xin cảm ơn!"
    }

    if (input === ("shop có bán giày nike không") || input === ("shop có bán giày adidas không") || input === ("shop có bán giày jordan không")
        || input === ("shop có giày nike không") || input === ("shop có giày adidas không") || input === ("shop có giày jordan không")
        || input === ("có giày nike không shop") || input === ("có giày adidas không shop") || input === ("có giày jordan không shop")
        || input === ("shop có giày nike không ạ") || input === ("shop có giày adidas không ạ") || input === ("shop có giày jordan không ạ")

        || input === ("có giày nike không") || input === ("có giày adidas không") || input === "có giày jordan không"
        || input === ("có bán giày nike không") || input === ("có bán giày adidas không") || input === "có bán giày jordan không"
        || input === ("có giày nike không ạ") || input === ("có giày adidas không ạ") || input === "có giày jordan không ạ"

        || input === ("shop có bán giày nike không") || input === ("shop có bán giày adidas không") || input === ("shop có bán giày jordan không")
        || input === ("có bán giày nike không shop") || input === ("có bán giày adidas không shop") || input === ("có bán giày jordan không shop")
        || input === ("shop có bán giày nike không ạ") || input === ("shop có bán giày adidas không ạ") || input === "shop có bán giày jordan không ạ"

        || input === ("bán giày nike không") || input === ("bán giày adidas không") || input === ("bán giày jordan không")
        || input === ("bán giày nike không shop") || input === ("bán giày adidas không shop") || input === ("bán jordan không shop")
        || input === ("shop có giày nike không ạ") || input === ("bán giày adidas không ạ") || input === "bán giày jordan không ạ"
    ) {
        return "Dạ có ạ. Bạn có thể tham khảo các mẫu giày của shop tại https://localhost:44379/ ạ.";
    }

    else if (input === ("Shop có bán giày nike không") || input === ("Shop có bán giày adidas không")
        || input === ("Shop có bán giày jordan không")) {
        return "Dạ có ạ. Anh/chị có thể tham khảo các mẫu giày của shop tại https://localhost:44379/ ạ.";
    }

    else if (input === ("shop có bán các hãng giày gì vậy") || input === ("shop có bán giày hãng gì vậy") || input === ("shop có hãng giày gì vậy") || input === ("shop có hãng gì")
        || input === ("shop bán các hãng giày gì vậy") || input === ("shop bán giày gì vậy") || input === ("có hãng giày gì vậy") || input === ("shop có hãng gì vậy")
        || input === ("có bán các hãng giày gì vậy shop") || input === ("có bán giày gì vậy shop") || input === ("có hãng giày gì vậy shop") || input === ("có hãng gì vậy shop")
        || input === ("có bán các hãng giày gì vậy") || input === ("có bán giày gì vậy") || input === ("có hãng giày gì vậy") || input === ("có hãng giày gì")
        || input === ("có bán giày các hãng gì vậy") || input === ("có bán giày hãng gì vậy shop") || input === ("có giày hãng gì vậy") || input === ("có hãng gì vậy")
        || input === ("bán giày các hãng gì vậy shop") || input === ("bán giày hãng gì vậy shop") || input === ("có giày hãng gì vậy shop") || input === ("có hãng giày gì vậy shop")
        || input === ("shop có bán các hãng giày gì vậy") || input === ("shop có bán giày hãng gì vậy") || input === ("shop có giày hãng gì vậy") || input === ("shop có hãng gì")

        || input === ("shop bán các hãng giày gì") || input === ("shop bán giày hãng gì") || input === ("có giày hãng gì") || input === ("shop có hãng giày gì")
        || input === ("có bán các hãng giày gì shop") || input === ("có bán giày hãng gì shop") || input === ("có hãng giày gì shop") || input === ("có hãng giày gì vậy shop")
        || input === ("có bán các hãng giày gì") || input === ("có bán giày hãng gì") || input === ("có bán giày hãng gì vậy shop") || input === ("có giày hãng gì")
        || input === ("có bán giày các hãng gì vậy") || input === ("có bán giày hãng gì vậy shop") || input === ("có giày hãng gì vậy") || input === ("có giày hãng gì vậy shop")
        || input === ("shop có bán giày hãng nào") || input === ("shop có giày hãng nào") || input === ("có bán giày hãng gì shop") || input === ("có hãng giày gì shop")
        || input === ("shop có giày của hãng nào") || input === ("shop bán giày của hãng nào") || input === ("shop có bán giày của hãng nào") || input === ("có giày của hãng nào shop")
    ) {
        return "Bên shop có hãng Nike, Adidas và Jordan. Anh/chị có thể tìm xem trực tiếp tại https://localhost:44379/ ạ.";
    }

    else if (input === ("shop có giày chanel không") || input === ("shop có giày gucci không") || input === ("shop có bán giày gucci không")
        || input === ("có giày chanel không shop") || input === ("có giày gucci không shop")
        || input === ("shop có giày chanel không ạ") || input === ("shop có giày gucci không ạ")
        || input === ("cho em hỏi là shop có giày gucci không") || input === ("cho em hỏi là shop có giày chanel không")
        || input === ("shop có giày gucci không")

        || input === ("có giày chanel không") || input === ("có giày gucci không") || input === ("có bán giày gucci không")
        || input === ("có giày hãng chanel không") || input === ("có giày hãng gucci không")
        || input === ("shop bán giày chanel không") || input === ("shop bán giày gucci không")
        || input === ("shop có giày hãng chanel không") || input === ("có giày hãng chanel không shop")
        || input === ("có giày hãng gucci không shop")
    ) {
        return "Dạ không ạ. Anh/chị thông cảm shop chỉ có các hãng nike, adidas và jordan thôi ạ."
    }
    //======================================================================================================================//




    //====================================================== TƯ VẤN VỀ SIZE ==========================================//

    if (input === "tư vấn về size" || input === "tôi cần tư vấn về size" || input === "tư vấn cho tôi size giày của shop" || input === "tôi muốn được tư vấn về size" || input === "tôi cần hỏi về size giày của shop" || input === "tôi muốn hỏi về size" || input === "tôi muốn tư vấn về size"
        || input === "tư vấn size" || input === "tôi cần tư vấn size" || input === "tư vấn cho tôi size giày" || input === "tôi muốn được tư vấn size" || input === "tôi cần hỏi về size" || input === "tôi muốn hỏi về size" || input === "tôi muốn được tư vấn về size"
        || input === "tôi cần hỏi size" || input === "tôi cần hỏi size giày" || input === "tư vấn size giày" || input === "tư vấn về size giày" || input === "tư vấn size giày cho tôi" || input === "tôi cần tư vấn size giày" || input === "tôi muốn hỏi size" || input === "tôi cần tư vấn về size giày"
        || input === "cần tư vấn size" || input === "mình cần tư vấn size" || input === "mình cần tư vấn về size" || input === "mình muốn được tư vấn về size giày" || input === "mình cần tư vấn về size giày" || input === "tôi muốn tư vấn về size giày"
        || input === "size" || input === "cần tư vấn size giày" || input === "mình muốn được tư vấn về size" || input === "mình cần shop tư vấn size giày" || input === "tôi muốn tư vấn size" || input === "em muốn được tư vấn về size giày"
        || input === "có bao nhiêu size" || input === "shop có những size nào" || input === "mình cần hỏi về size giày của shop" || input === "mình muốn hỏi về size" || input === "mình muốn hỏi về size giày" || input === "mình muốn tư vấn về size giày" || input === "mình cần hỏi về size giày"
        || input === "em cần tư vấn size giày" || input === "em cần tư vấn về size giày" || input === "em cần tư vấn size" || input === "em cần tư vấn về size giày của shop" || input === "em muốn hỏi size" || input === "em muốn được tư vấn size" || input === "em muốn được tư vấn về size"
        || input === "em cần hỏi về size" || input === "em cần hỏi về size giày" || input === "em cần hỏi về vấn đề size giày" || input === "em muốn hỏi size giày" || input === "em muốn hỏi vấn đề size" || input === "tư vấn cho em muốn size giày"
        || input === "hãy tư vấn size giày cho tôi" || input === "tư vấn size giày của shop cho tôi" || input === "tư vấn cho tôi size giày của shop bạn" || input === "hãy tư vấn size giày của shop bạn cho tôi" || input === "tôi muốn được tư vấn về size giày" || input === "tôi muốn được tư vấn về size"
        || input === "tư vấn cho tôi về size giày bạn bán" || input === "cho tôi biết một số size giày của shop" || input === "cho tôi biết một số size giày của shop đang bán" || input === "cho tôi biết một số size giày của shop bán"
        || input === "hãy tư vấn size giày của cửa hàng bạn cho tôi" || input === "hãy tư vấn cho tôi size giày của shop bạn" || input === "hãy tư vấn size giày của cửa hàng cho tôi" || input === "hãy tư vấn size giày của shop cho tôi"

    ) {
        return "Giày của shop đều có size chuẩn.<br/>Có đầy đủ các size từ 30-46 anh/chị có thể thỏa mái chọn lựa.<br/>Thông tin chi tiết anh/chị vui lòng tham khảo tại https://localhost:44379/.<br/>Xin cảm ơn!"
    }

    else if (input === "shop có size 30 không" || input === "shop có size 31 không" || input === "shop có size 32 không" || input === "shop có size 33 không" || input === "shop có size 34 không"
        || input === "shop có size 35 không" || input === "shop có size 36 không" || input === "shop có size 37 không" || input === "shop có size 38 không" || input === "shop có size 39 không"
        || input === "shop có size 40 không" || input === "shop có size 41 không" || input === "shop có size 42 không" || input === "shop có size 43 không" || input === "shop có size 44 không"
        || input === "shop có size 45 không" || input === "shop có size 46 không"
        || input === "có size 30 không" || input === "có size 31 không" || input === "có size 32 không" || input === "có size 33 không" || input === "có size 34 không"
        || input === "có size 35 không" || input === "có size 36 không" || input === "có size 37 không" || input === "có size 38 không" || input === "có size 39 không"
        || input === "có size 40 không" || input === "có size 41 không" || input === "có size 42 không" || input === "có size 43 không" || input === "có size 44 không"
        || input === "có size 45 không" || input === "có size 46 không"
        || input === "có size 30 không shop" || input === "có size 31 không shop" || input === "có size 32 không shop" || input === "có size 33 không shop" || input === "có size 34 không shop"
        || input === "có size 35 không shop" || input === "có size 36 không shop" || input === "có size 37 không shop" || input === "có size 38 không shop" || input === "có size 39 không shop"
        || input === "có size 40 không shop" || input === "có size 41 không shop" || input === "có size 42 không shop" || input === "có size 43 không shop" || input === "có size 44 không shop"
        || input === "có size 45 không shop" || input === "có size 46 không shop"
        || input === "shop còn size 30 không" || input === "shop còn size 31 không" || input === "shop còn size 32 không" || input === "shop còn size 33 không" || input === "shop còn size 34 không"
        || input === "shop còn size 35 không" || input === "shop còn size 36 không" || input === "shop còn size 37 không" || input === "shop còn size 38 không" || input === "shop còn size 39 không"
        || input === "shop còn size 40 không" || input === "shop còn size 41 không" || input === "shop còn size 42 không" || input === "shop còn size 43 không" || input === "shop còn size 44 không"
        || input === "shop còn size 45 không" || input === "shop còn size 46 không"
        || input === "còn size 30 không" || input === "còn size 31 không" || input === "còn size 32 không" || input === "còn size 33 không" || input === "còn size 34 không"
        || input === "còn size 35 không" || input === "còn size 36 không" || input === "còn size 37 không" || input === "còn size 38 không" || input === "còn size 39 không"
        || input === "còn size 40 không" || input === "còn size 41 không" || input === "còn size 42 không" || input === "còn size 43 không" || input === "còn size 44 không"
        || input === "còn size 45 không" || input === "còn size 46 không"
        || input === "còn size 30 không shop" || input === "còn size 31 không shop" || input === "còn size 32 không shop" || input === "còn size 33 không shop" || input === "còn size 34 không shop"
        || input === "còn size 35 không shop" || input === "còn size 36 không shop" || input === "còn size 37 không shop" || input === "còn size 38 không shop" || input === "còn size 39 không shop"
        || input === "còn size 40 không shop" || input === "còn size 41 không shop" || input === "còn size 42 không shop" || input === "còn size 43 không shop" || input === "còn size 44 không shop"
        || input === "còn size 45 không shop" || input === "còn size 46 không shop"
    ) {
        return "Dạ có nha anh/chị. Bên shop có đầy đủ các size từ 30 - 46 của tất cả các mẫu.<br/>Anh/chị có thể tham khảo các mẫu giày của shop tại https://localhost:44379/ ";
    }

    else if (input === "có size 47 không shop" || input === "có size 48 không shop" || input === "có size 47 không" || input === "có size 48 không"
        || input === "có size 28 không shop" || input === "có size 29 không shop" || input === "có size 29 không" || input === "có size 28 không"
        || input === "shop có size 47 không" || input === "shop có size 48 không" || input === "còn size 47 không" || input === "còn size 48 không"
        || input === "shop có size 28 không" || input === "shop có size 29 không" || input === "còn size 29 không" || input === "còn size 28 không"

    ) {
        return "Mong anh/chị thông cảm.<br/>Shop chỉ có size từ 30 đến 46."
    }
    //======================================================================================================================//




    //============================================= TƯ VẤN ĐỊA CHỈ SHOP ==========================================//

    if (input === ("địa chỉ của mình ở đâu vậy") || input === ("địa chỉ shop ở đâu vậy")
        || input === ("shop cho em xin địa chỉ được không") || input === ("shop cho em xin địa chỉ")) {
        return "Anh/chị có thể đến cửa hàng tại Đ/C: C12/1A, đường 455, Phường Tăng Nhơn Phú A, Tp.Thủ Đức."
    } else if (input === ("shop cho mình xin địa chỉ được không") || input === ("shop cho mình xin địa chỉ")
        || input === ("shop ở đâu vậy")) {
        return "Anh/chị có thể đến cửa hàng tại Đ/C: C12/1A, đường 455, Phường Tăng Nhơn Phú A, Tp.Thủ Đức."
    } else if (input === ("cho số điện thoại đi shop ") || input === ("shop ơi cho em xin sđt") || input === ("shop ơi cho anh xin sđt")
        || input === ("shop ơi cho chị xin sđt") || input === ("shop ơi cho mình xin sđt") || input === ("shop cho em xin số điện thoại được không")
        || input === ("shop cho anh xin số điện thoại được không") || input === ("shop cho chị xin số điện thoại")
        || input === ("shop cho em xin sđt") || input === ("shop cho mình xin sdt")) {
        return "Dạ được, anh/chị có thể liên hệ SDT: 0374160067 sẽ có nhân viên hỗ trợ mình nhé!";
    }
    //=========================================================================================================================//

    //======================================= TƯ VẤN VỀ LOẠI GIÀY ===================================================//

    if (input === ("shop có bán giày sneaker không") || input === ("shop có bán giày street không")
        || input === ("shop có bán giày custom không") || input === ("shop có bán giày comfort không")) {
        return "Dạ có ạ. Anh/chị có thể tham khảo chi tiết các mẫu giày của shop tại https://localhost:44379/ ạ.";
    } else if (input === ("có bán giày sneaker không") || input === ("có bán giày street không")
        || input === ("có bán giày custom không") || input === ("có bán giày comfort không")
        || input === ("có bán giày sneaker không shop") || input === ("có bán giày street không shop")
        || input === ("có bán giày custom không shop") || input === ("có bán giày comfort không shop")) {
        return "Dạ có ạ. Anh/chị có thể tham khảo chi tiết các mẫu giày của shop tại https://localhost:44379/ ạ.";
    } else if (input === ("Shop có giày sneaker không ạ") || input === ("Shop bán giày street không ạ")
        || input === ("Shop có bán giày custom không ạ") || input === ("Shop có giày comfort không ạ")) {
        return "Dạ có ạ. Anh/chị có thể tham khảo chi tiết các mẫu giày của shop tại https://localhost:44379/ ạ.";
    } else if (input === ("shop có bán các loại giày gì vậy") || input === ("shop có loại giày gì") || input === ("shop có loại giày gì vậy")) {
        return "Bên shop có các loại Sneaker, Street, Comfort và Custom. Anh/chị có thể xem chi tiết các sản phẩm tại https://localhost:44379/.";
    } else if (input === ("shop có giày đá bóng không") || input === ("shop có giày đá bóng không") || input === ("shop có giày thể thao không") || input === ("shop có giày chạy bộ không")
        || input === ("có giày đá bóng không") || input === ("có giày thể thao không") || input === ("có giày chạy bộ không")
        || input === ("có giày đá bóng không ạ") || input === ("có giày thể thao không ạ") || input === ("có giày chạy bộ không ạ")
        || input === ("có bán giày bóng đá không shop") || input === ("có giày đá bóng không shop")) {
        return "Anh/chị thông cảm ạ. Shop chỉ có các loại giày như Sneaker, Street, Comfort và Custom thôi ạ."
    }
    //========================================================================================================================//



    //================================================ QUÊN MẬT KHẨU =================================================//

    if (input === ("shop ơi em lỡ quên mật khẩu thì sao ạ") || input === ("shop ơi mình lỡ quên mật khẩu thì sao")
        || input === ("lỡ quên mật khẩu thì sao shop") || input === ("shop ơi em lỡ quên mật khẩu thì sao ạ")
        || input === ("anh lỡ quên mật khẩu thì sao shop") || input === ("shop ơi anh lỡ quên mật khẩu thì sao")
        || input === ("chị lỡ quên mật khẩu thì sao shop") || input === ("shop ơi chị lỡ quên mật khẩu thì sao")
        || input === ("shop ơi lỡ quên mật khẩu thì sao shop") || input === ("em lỡ quên mật khẩu thì sao ạ")) {
        return "Anh/chị vào mục đăng nhập sau đó click vào mục quên mật khẩu sau đó làm theo hướng dẫn để đổi mật khẩu ạ.";
    } else if (input === ("ok")) {
        return "";
    }
    //=========================================================================================================================//




    //============================================== BẢO HÀNH ==========================================================//

    if (input === ("vậy bảo hành thì thế nào") || input === ("vậy bảo hành thì thế nào shop") || input === ("bảo hành thì thế nào")
        || input === ("bảo hành thì thế nào shop") || input === ("vậy bảo hành thì sao shop")) {
        return "Mỗi sản phẩm sẽ có thời gian bảo hành, kèm điều kiện khác nhau anh/chị có thể xem chi tiết ở phần mô tả sản phẩm ạ."
    } else if (input === ("sản phẩm có bảo hành không shop") || input === ("giày có bảo hành không shop") || input === ("thế có bảo hành không")
        || input === ("vậy có bảo hành không shop")) {
        return "Dạ có. Anh/chị xem chi tiết ở phần mô tả sản phẩm ạ."
    }
    //======================================================================================================================//



    //=================================================== ĐẶT HÀNG ====================================================//

    if (input === ("phí ship bao nhiêu vậy") || input === ("phí ship bao nhiêu vậy shop") || input === ("tiền ship bao nhiêu vậy")
        || input === ("tiền ship bao nhiêu vậy shop") || input === ("được miễn phí ship không shop") || input === ("có tốn phí ship không shop")
        || input === ("được free ship không shop") || input === ("phí ship bao nhiêu vậy") || input === ("mua 1 đôi có tốn phí ship không")
        || input === ("mua 1 đôi có tốn phí ship không shop") || input === ("mua 1 đôi được free ship không shop") || input === ("mua ít được free ship không shop")) {
        return "Shop miễn phí giao hàng toàn quốc không tính số lượng nha anh/chị.";
    } else if (input === ("đặt hàng bao lâu thì có hàng vậy shop") || input === ("đặt hàng bao lâu thì giao vậy shop")
        || input === ("mấy ngày có hàng vậy shop") || input === ("bao lâu thì có hàng vậy shop") || input === ("khoảng mấy ngày có hàng vậy shop")
        || input === ("mấy ngày có hàng vậy") || input === ("mấy ngày có hàng vậy shop") || input === ("khoảng mấy ngày có hàng vậy shop")) {
        return "Bình thường thì khoảng 3 -> 5 ngày ạ."
    } else if (input === ("sao lâu có hàng quá vậy shop") || input === ("đặt lâu rồi mà sao chưa có hàng vậy shop")
        || input === ("shop ơi sao lâu có hàng quá vậy")) {
        return "Anh/chị thông cảm, có thể bên giao hàng đang có trục trặc khoảng 1 -> 2 ngày sau mới đến nơi ạ."
    } else if (input === ("shop giao hàng nhanh thật") || input === ("shop giao hàng nhanh") || input === ("nhận hàng rồi nha shop") || input === ("hàng đẹp lắm shop")
        || input === ("giày đẹp quá shop ơi") || input === ("hàng chất lượng quá") || input === ("giày quá đẹp")) {
        return "Cảm ơn anh/chị đã ủng hộ. Chúc anh/chị một ngày tốt lành!"
    }
    //=========================================================================================================================//




    //====================================================== GIÁ CẢ ======================================================//
    if (input === ("sao giá đắt vậy") || input === ("sao giày đắt vậy") || input === ("sao quá vậy shop") || input === ("shop bán đắt quá")
        || input === ("shop sao giá đắt vậy") || input === ("shop sao giày giá đắt vậy") || input === ("ahop sao giày đắt vậy")
        || input === ("giày đắt vậy shop") || input === ("sao giá cao vậy shop") || input === ("giày giá cao vậy")) {
        return "Sản phẩm bên shop là hàng chính hãng nên có giá cao. Anh/chị sẽ được đảm bảo về chất lượng sản phẩm ạ."
    }
    //======================================================================================================================//




    //============================================== KẾT THÚC CHAT ===================================================//

    if (input === "bye" || input === ("tạm biệt") || input === ("bye shop")
        || input === ("bye bye") || input === ("hẹn gặp lại") || input === ("bye")) {
        return "Hẹn gặp lại anh/chị! Cảm ơn anh/chị đã quan tâm. Chúc anh/chị một ngày tốt lành.";
    } else if (input === "Bye" || input === ("Tạm biệt") || input === ("Bye shop")
        || input === ("Bye bye") || input === ("Hẹn gặp lại") || input === ("Bye")) {
        return "Tạm biệt! Cảm ơn anh/chị đã quan tâm. Nếu còn thắc mắc anh/chị có thể liên hệ trực tiếp với shop tại Đ/c:dangduymanh2010@gmail.com. Chúc anh/chị một ngày tốt lành.";
    }

    if (input === ("cảm ơn") || input === ("cảm ơn shop") || input === ("cảm ơn ạ") || input === ("em cảm ơn") || input === ("cảm ơn shop nhiều") || input === ("thank shop")) {
        return "Vâng ạ. Chúc anh/chị mua hàng vui vẻ <.>!"
    } else if ("") {
        return "";
    }
    //========================================================================================================================//

    else {
        return 'Thành thật xin lỗi anh/chị!<br/>Hệ thống không thể trả lời câu hỏi này.<br/>Anh/chị vui lòng đợi câu trả lời từ Admin hoặc liên hệ SDT: 0374160067 để được tư vấn chi tiết.<br/>Xin cảm ơn!';
    }

}
