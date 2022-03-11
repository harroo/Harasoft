
using System;
using System.Net;
using System.Collections.Generic;

namespace Harasoft {

    namespace Net {

        public static partial class Image {

            public static Queue<Action<byte[]>> onCompleteMethods = new Queue<Action<byte[]>>();

            private static WebClient webClient = new WebClient();

            public static void Download (string url, Action<byte[]> onCompleteMethod) {

                onCompleteMethods.Enqueue(onCompleteMethod);

                webClient.DownloadDataCompleted += OnDownloadFinish;
                webClient.DownloadDataAsync(new Uri(url));
            }

            private static void OnDownloadFinish (object sender, DownloadDataCompletedEventArgs e) {

                Action<byte[]> onCompleteMethod = onCompleteMethods.Dequeue();

                if (e.Error != null) return;

                onCompleteMethod(e.Result);
            }
        }
    }
}
